using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;
using System.Web;
using Olive;
using Olive.Entities;
using Olive.Mvc;
using Olive.Web;
using Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using vm = ViewModel;

namespace Controllers
{
    [EscapeGCop("Auto generated code.")]
    #pragma warning disable
    public partial class LoginResetPasswordController : BaseController
    {
        [Route("password/reset/{ticket}")]
        public async Task<ActionResult> Index(vm.ResetUserPassword info)
        {
            // Remove initial validation messages as well as unintended injected data
            ModelState.Clear();
            
            return View(info);
        }
        
        [HttpPost("ResetUserPassword/Reset")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Reset(vm.ResetUserPassword info)
        {
            if ((info.Ticket.IsExpired || info.Ticket.IsUsed))
            {
                Notify("This ticket is no longer valid. Please request a new ticket.");
                return JsonActions(info);
            }
            
            await PasswordResetService.Complete(info.Ticket, info.Password.Trim());
            
            return AjaxRedirect(Url.Index("LoginResetPasswordConfirm", new { item = info.Ticket.UserId }));
        }
        
        [NonAction, OnBound]
        public async Task OnBound(vm.ResetUserPassword info)
        {
            info.Item = info.Ticket.User;
            
            if (Request.IsGet()) await info.Item.CopyDataTo(info);
        }
        
        protected override async Task<bool> AuthorizeRequestParams(ActionExecutingContext context)
        {
            if (!(Request.Has("Ticket")))
                return false;
            
            return await base.AuthorizeRequestParams(context);
        }
    }
}

namespace ViewModel
{
    [EscapeGCop("Auto generated code.")]
    #pragma warning disable
    public partial class ResetUserPassword : IViewModel
    {
        [ValidateNever]
        public PasswordResetTicket Ticket { get; set; }
        
        [ReadOnly(true)]
        public User Item { get; set; }
        
        [Required, DataType(DataType.Password)]
        [StringLength(100, ErrorMessage = "Password should not exceed 100 characters.")]
        public string Password { get; set; }
        
        [Required(ErrorMessage="Invalid data.")]
        [System.ComponentModel.DataAnnotations.Compare("Password",ErrorMessage="New password and Confirm password do not match. Please try again.")]
        public string ConfirmPassword { get; set; }
    }
}
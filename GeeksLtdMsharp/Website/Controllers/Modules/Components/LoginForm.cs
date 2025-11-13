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
using Olive.Security;
using Olive.Web;
using BotDetect.Web.Mvc;
using Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using vm = ViewModel;

namespace ViewComponents
{
    [EscapeGCop("Auto generated code.")]
    #pragma warning disable
    public partial class LoginForm : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(vm.LoginForm info)
        {
            return View(await Bind<vm.LoginForm>(info));
        }
    }
}

namespace Controllers
{
    [EscapeGCop("Auto generated code.")]
    #pragma warning disable
    public partial class LoginFormController : BaseController
    {
        [HttpPost("LoginForm/Login")]
        public async Task<ActionResult> Login(vm.LoginForm info)
        {
            var user = await Domain.User.FindByEmail(info.Email);
            
            if (user != null && user.IsDeactivated)
            {
                Notify("Your account is deactivated. Please contact an administrator.", "error");
                return View(info);
            }
            
            if ((user == null || !SecurePassword.Verify(info.Password, user.Password, user.Salt)))
            {
                Notify("Invalid username and/or password. Please try again.", "error");
                info.ShowCaptcha = await LogonFailure.MustShowCaptcha(info.Email, Request.GetIPAddress());
                return View(info);
            }
            
            await user.LogOn();
            
            await LogonFailure.Remove(info.Email, Request.GetIPAddress());
            
            if (Url.ReturnUrl().HasValue() && Url.ReturnUrl() != Url.Index("Login"))
            {
                return Redirect(Url.ReturnUrl());
            }
            
            return Redirect(Url.Index("LoginDispatch"));
        }
        
        [NonAction, OnBound]
        public async Task OnBound(vm.LoginForm info)
        {
            info.Item = await Domain.User.FindByEmail(info.Email);
        }
    }
}

namespace ViewModel
{
    [EscapeGCop("Auto generated code.")]
    #pragma warning disable
    [BindingController(typeof(Controllers.LoginFormController))]
    public partial class LoginForm : IViewModel
    {
        public bool ShowCaptcha { get; set; }
        
        public string CaptchaCode { get; set; }
        
        [ReadOnly(true)]
        public User Item { get; set; }
        
        [Required]
        [EmailAddress(ErrorMessage = "Email should be a valid Email address.")]
        [StringLength(100, ErrorMessage = "Email should not exceed 100 characters.")]
        public string Email { get; set; }
        
        [Required, DataType(DataType.Password)]
        [StringLength(100, ErrorMessage = "Password should not exceed 100 characters.")]
        public string Password { get; set; }
    }
}
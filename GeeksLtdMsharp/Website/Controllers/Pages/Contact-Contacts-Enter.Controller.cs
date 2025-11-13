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
    public partial class ContactContactsEnterController : BaseController
    {
        [Route("contact/contacts/enter/{item:Guid?}")]
        public async Task<ActionResult> Index(vm.SharedView sharedView, vm.ContactForm contactForm)
        {
            // Remove initial validation messages as well as unintended injected data
            ModelState.Clear();
            
            ViewBag.SharedView = sharedView;
            ViewData["LeftMenu"] = "AdminSettingsMenu";
            
            return View(contactForm);
        }
        
        [HttpPost("ContactForm/Save")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Save(vm.ContactForm info)
        {
            try
            {
                if (!await SaveInDatabase(info)) return JsonActions(info);
            }
            catch (Olive.Entities.ValidationException ex)
            {
                return Notify(ex.Message, "error");
            }
            
            Notify("Saved successfully.", obstruct: false);
            
            Do(WindowAction.CloseModalRebindParent);
            
            return JsonActions(info);
        }
        
        [NonAction, OnBound]
        public async Task OnBound(vm.ContactForm info)
        {
            info.Item = info.Item ?? new Contact();
            
            if (Request.IsGet()) await info.Item.CopyDataTo(info);
        }
        
        [NonAction]
        public async Task<bool> SaveInDatabase(vm.ContactForm info)
        {
            if (!ModelState.IsValid(info))
            {
                Notify(ModelState.GetErrors().ToLinesString(), "error");
                return false;
            }
            
            var item = info.Item.IsNew ? info.Item : info.Item.Clone();
            
            await info.CopyDataTo(item); // Read the ViewModel data into the domain object.
            
            using (var scope = Database.CreateTransactionScope())
            {
                try
                {
                    info.Item = await Database.Save(item);
                    
                    scope.Complete();
                    return true;
                }
                catch (Olive.Entities.ValidationException ex)
                {
                    Notify(ex.ToFullMessage(), "error");
                }
                
                return false;
            }
        }
        
        [NonAction, OnPreBound]
        public async Task OnBinding(vm.SharedView info)
        {
            info.Mode = "Enter";
        }
    }
}

namespace ViewModel
{
    [EscapeGCop("Auto generated code.")]
    #pragma warning disable
    public partial class ContactForm : IViewModel
    {
        [ValidateNever]
        public Contact Item { get; set; }
        
        [Required, DisplayName("First name")]
        [StringLength(200, ErrorMessage = "First name should not exceed 200 characters.")]
        public string FirstName { get; set; }
        
        [Required, DisplayName("Last name")]
        [StringLength(200, ErrorMessage = "Last name should not exceed 200 characters.")]
        public string LastName { get; set; }
        
        [Required, DisplayName("Phone number")]
        [StringLength(200, ErrorMessage = "Phone number should not exceed 200 characters.")]
        public string PhoneNumber { get; set; }
    }
}
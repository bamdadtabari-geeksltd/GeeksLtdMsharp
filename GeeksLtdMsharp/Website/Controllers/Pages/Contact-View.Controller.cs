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
    public partial class ContactViewController : BaseController
    {
        [Route("contact/contacts/view/{item}")]
        public async Task<ActionResult> Index(vm.SharedView sharedView, vm.ContactView contactView)
        {
            ViewBag.SharedView = sharedView;
            ViewData["LeftMenu"] = "AdminSettingsMenu";
            
            return View(contactView);
        }
        
        [HttpPost("ContactView/Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(vm.ContactView info)
        {
            try
            {
                await Database.Delete(info.Item);
            }
            catch (Exception ex)
            {
                Log.Error(ex);
                return Notify(ex.Message, "error");
            }
            
            Notify("Deleted successfully.", obstruct: false);
            
            return AjaxRedirect(Url.ReturnUrl());
        }
        
        [NonAction, OnPreBound]
        public async Task OnBinding(vm.SharedView info)
        {
            info.Mode = "View";
        }
    }
}

namespace ViewModel
{
    [EscapeGCop("Auto generated code.")]
    #pragma warning disable
    public partial class ContactView : IViewModel
    {
        [ValidateNever]
        public Contact Item { get; set; }
    }
}
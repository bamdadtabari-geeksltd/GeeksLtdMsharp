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
    [Authorize(Roles = "Admin, PM")]
    [EscapeGCop("Auto generated code.")]
    #pragma warning disable
    public partial class ProductViewController : BaseController
    {
        [Route("product/view/{item:Guid}")]
        public async Task<ActionResult> Index(vm.ProductView info)
        {
            ViewData["LeftMenu"] = "AdminSettingsMenu";
            
            return View(info);
        }
        
        [HttpPost("ProductView/Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(vm.ProductView info)
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
    }
}

namespace ViewModel
{
    [EscapeGCop("Auto generated code.")]
    #pragma warning disable
    public partial class ProductView : IViewModel
    {
        [ValidateNever]
        public Product Item { get; set; }
    }
}
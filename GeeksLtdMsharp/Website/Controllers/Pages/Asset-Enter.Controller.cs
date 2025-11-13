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
    public partial class AssetEnterController : BaseController
    {
        [Route("asset/enter/{item:Guid?}")]
        public async Task<ActionResult> Index(vm.AssetForm info)
        {
            // Remove initial validation messages as well as unintended injected data
            ModelState.Clear();
            
            ViewData["LeftMenu"] = "AdminSettingsMenu";
            
            return View(info);
        }
        
        [HttpPost("AssetForm/Save")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Save(vm.AssetForm info)
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
            
            return AjaxRedirect(Url.ReturnUrl());
        }
        
        [NonAction, OnBound]
        public async Task OnBound(vm.AssetForm info)
        {
            info.Item = info.Item ?? new Asset();
            
            if (Request.IsGet()) await info.Item.CopyDataTo(info);
            
            info.Type_Options.Clear();
            info.Type_Options.Add(new EmptyListItem());
            info.Type_Options.AddRange(await Database.GetList<AssetType>());
            
            info.Owner_Options.Clear();
            info.Owner_Options.Add(new EmptyListItem());
            info.Owner_Options.AddRange(await Database.GetList<Owner>());
        }
        
        [NonAction]
        public async Task<bool> SaveInDatabase(vm.AssetForm info)
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
    }
}

namespace ViewModel
{
    [EscapeGCop("Auto generated code.")]
    #pragma warning disable
    public partial class AssetForm : IViewModel
    {
        [ValidateNever]
        public Asset Item { get; set; }
        
        [StringLength(200, ErrorMessage = "Code should not exceed 200 characters.")]
        public string Code { get; set; }
        
        [StringLength(200, ErrorMessage = "Name should not exceed 200 characters.")]
        public string Name { get; set; }
        
        public AssetType Type { get; set; }
        
        [Range(0, double.MaxValue, ErrorMessage="Cost should be 0 or more.")]
        public decimal? Cost { get; set; }
        
        public Owner Owner { get; set; }
        
        [ReadOnly(true)]
        public List<SelectListItem> Type_Options = new List<SelectListItem>();
        
        [ReadOnly(true)]
        public List<SelectListItem> Owner_Options = new List<SelectListItem>();
    }
}
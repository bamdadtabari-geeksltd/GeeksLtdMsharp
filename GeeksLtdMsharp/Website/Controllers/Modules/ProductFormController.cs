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
    public partial class ProductFormController : BaseController
    {
        [HttpPost("ProductForm/Save")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Save(vm.ProductForm info)
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
        public async Task OnBound(vm.ProductForm info)
        {
            info.Item = info.Item ?? new Product();
            
            if (Request.IsGet()) await info.Item.CopyDataTo(info);
            
            if (Request.Has("productCategory"))
            {
                info.ProductCategory = await Request.Get<ProductCategory>("productCategory");
            }
            
            info.IsFood_Options.Clear();
            info.IsFood_Options.Add("Food", true);
            info.IsFood_Options.Add("Not food", false);
            
            info.ProductCategory_Options.Clear();
            info.ProductCategory_Options.Add(new EmptyListItem());
            info.ProductCategory_Options.AddRange(await Database.GetList<ProductCategory>());
        }
        
        [NonAction]
        public async Task<bool> SaveInDatabase(vm.ProductForm info)
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
    [BindingController(typeof(Controllers.ProductFormController))]
    public partial class ProductForm : IViewModel
    {
        [ValidateNever]
        public Product Item { get; set; }
        
        [Required(ErrorMessage="Please Set Product Name")]
        [StringLength(200, ErrorMessage = "Name should not exceed 200 characters.")]
        public string Name { get; set; }
        
        [DataType(DataType.DateTime)]
        [DisplayName("Production date/time")]
        [Required(ErrorMessage="Please add the time and date!")]
        public DateTime? ProductionDate_time { get; set; }
        
        [Required, DisplayName("Is Food")]
        public bool IsFood { get; set; }
        
        [Required, DisplayName("Product website")]
        [StringLength(200, ErrorMessage = "Product website should not exceed 200 characters.")]
        [RegularExpression("^(ht|f)tp(s?)\\:\\/\\/[0-9a-zA-Z]([-.\\w]*[0-9a-zA-Z])*(:(0-9)*)*(\\/?)([a-zA-Z0-9\\u00a1-\\uffff\\-\\.\\?\\,\\'\\/\\\\\\\\(\\)\\;+&%\\$#=_]*)?$", ErrorMessage = "Please enter the product's website.")]
        public string ProductWebsite { get; set; }
        
        [Required]
        public BlobViewModel Photo { get; set; }
        
        public ProductCategory ProductCategory { get; set; }
        
        [ReadOnly(true)]
        public List<SelectListItem> IsFood_Options = new List<SelectListItem>();
        
        [ReadOnly(true)]
        public List<SelectListItem> ProductCategory_Options = new List<SelectListItem>();
    }
}
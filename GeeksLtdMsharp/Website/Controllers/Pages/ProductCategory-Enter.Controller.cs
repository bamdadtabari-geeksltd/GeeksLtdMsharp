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
    public partial class ProductCategoryEnterController : BaseController
    {
        [Route("product-category/enter/{item:Guid?}")]
        public async Task<ActionResult> Index(vm.ProductCategoryForm info)
        {
            // Remove initial validation messages as well as unintended injected data
            ModelState.Clear();
            
            return View(info);
        }
        
        [HttpPost("ProductCategoryForm/Save")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Save(vm.ProductCategoryForm info)
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
        
        [HttpPost("ProductCategoryForm_Products_DetailsForm/AddProduct")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AddProduct(vm.ProductCategoryForm info)
        {
            ModelState.Clear();
            var model = new vm.ProductCategoryForm.ProductsSubForm();
            await OnBound(model);
            return PartialView("ProductCategoryForm-Products", model);
        }
        
        [NonAction, OnBound]
        public async Task OnBound(vm.ProductCategoryForm info)
        {
            info.Item = info.Item ?? new ProductCategory();
            
            if (Request.IsGet())
            {
                await info.Item.CopyDataTo(info);
                
                info.Products = await info.Item.Products.GetList().Select(p => new vm.ProductCategoryForm.ProductsSubForm(p)).ToList();
                
                await Task.WhenAll(info.Products.Select(x => x.Item.CopyDataTo(x)));
                
                while (info.Products.Count() < 1)
                {
                    info.Products.Add(new vm.ProductCategoryForm.ProductsSubForm());
                }
            }
            
            await Task.WhenAll(info.Products.Select(OnBound));
        }
        
        [NonAction, OnBound]
        public async Task OnBound(vm.ProductCategoryForm.ProductsSubForm info)
        {
            if (Request.IsGet()) await info.Item.CopyDataTo(info);
            
            info.IsFood_Options.Clear();
            info.IsFood_Options.Add("Food", true);
            info.IsFood_Options.Add("Not food", false);
        }
        
        [NonAction]
        public async Task<bool> SaveInDatabase(vm.ProductCategoryForm info)
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
                    
                    // Persist the changes in Products
                    await Database.Delete(info.Products.Where(x => x.MustBeDeleted && !x.Item.IsNew).Select(x => x.Item).ExceptNull());
                    await Task.WhenAll(info.Products.Except(x => x.MustBeDeleted).Select(async x => { await x.CopyDataTo(x.Item); x.Item.ProductCategory = item;}));
                    await Database.Save(info.Products.Except(x => x.MustBeDeleted).Select(x => x.Item));
                    
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
    public partial class ProductCategoryForm : IViewModel
    {
        [ValidateNever]
        public ProductCategory Item { get; set; }
        
        [Required]
        [StringLength(200, ErrorMessage = "Name should not exceed 200 characters.")]
        public string Name { get; set; }
        
        [Required, MasterDetails("Products")]
        public List<ProductsSubForm> Products { get; set; } = new List<ProductsSubForm>();
        
        [EscapeGCop("Auto generated code.")]
        #pragma warning disable
        public partial class ProductsSubForm : IViewModel
        {
            public ProductsSubForm(): this(new Product())
            {
            }
            
            public ProductsSubForm(Product item)
            {
                Item = item.Clone();
            }
            
            public bool MustBeDeleted { get; set; }
            
            [ValidateNever]
            public Product Item { get; set; }
            
            [RequiredUnless(nameof(MustBeDeleted), ErrorMessage="Please Set Product Name")]
            [StringLengthUnless(nameof(MustBeDeleted), 200, ErrorMessage = "Name should not exceed 200 characters.")]
            public string Name { get; set; }
            
            [DisplayName("Production date/time")]
            [DataTypeUnless(nameof(MustBeDeleted), DataType.DateTime)]
            [RequiredUnless(nameof(MustBeDeleted), ErrorMessage="Please add the time and date!")]
            public DateTime? ProductionDate_time { get; set; }
            
            [DisplayName("Is Food")]
            [RequiredUnless(nameof(MustBeDeleted))]
            public bool IsFood { get; set; }
            
            [DisplayName("Product website")]
            [RequiredUnless(nameof(MustBeDeleted))]
            [StringLengthUnless(nameof(MustBeDeleted), 200, ErrorMessage = "Product website should not exceed 200 characters.")]
            [RegularExpression("^(ht|f)tp(s?)\\:\\/\\/[0-9a-zA-Z]([-.\\w]*[0-9a-zA-Z])*(:(0-9)*)*(\\/?)([a-zA-Z0-9\\u00a1-\\uffff\\-\\.\\?\\,\\'\\/\\\\\\\\(\\)\\;+&%\\$#=_]*)?$", ErrorMessage = "Please enter the product's website.")]
            public string ProductWebsite { get; set; }
            
            [RequiredUnless(nameof(MustBeDeleted))]
            public BlobViewModel Photo { get; set; }
            
            [ReadOnly(true)]
            public List<SelectListItem> IsFood_Options = new List<SelectListItem>();
        }
    }
}
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
    public partial class ProductsListController : BaseController
    {
        DatabaseFilters<Product> PlDatabaseFilters;
        
        [HttpPost("ProductsList/ThisButtonExportsToCSV")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> ThisButtonExportsToCSV(vm.ProductsList info)
        {
            try
            {
                return await ExportAs(info, Olive.Export.Format.Csv);
            }
            catch (Exception ex)
            {
                Log.Error(ex);
                return Notify(ex.Message, "error");
            }
        }
        
        [HttpPost("ProductsList/ThisButtonExportsToExcel")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> ThisButtonExportsToExcel(vm.ProductsList info)
        {
            try
            {
                return await ExportAs(info, Olive.Export.Format.ExcelXml);
            }
            catch (Exception ex)
            {
                Log.Error(ex);
                return Notify(ex.Message, "error");
            }
        }
        
        [HttpPost("ProductsList/Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(vm.ProductsList info, [Bind(Prefix="list.item")] Product item)
        {
            try
            {
                await Database.Delete(item);
            }
            catch (Exception ex)
            {
                Log.Error(ex);
                return Notify(ex.Message, "error");
            }
            
            return Do(WindowAction.Refresh);
            
            Do(WindowAction.ShowPleaseWait);
            
            return JsonActions(info);
        }
        
        [HttpPost("ProductsList/ProductCategoryChanged")]
        public async Task<ActionResult> ProductCategoryChanged(vm.ProductsList info)
        {
            return View(info);
        }
        
        [NonAction, OnBound]
        public async Task OnBound(vm.ProductsList info)
        {
            PlDatabaseFilters = new DatabaseFilters<Product>();
            
            info.ProductCategory_Options.Clear();
            info.ProductCategory_Options.Add(new EmptyListItem("All"));
            info.ProductCategory_Options.AddRange(await Database.GetList<ProductCategory>());
            
            if (info.ProductCategory != null)
            {
                PlDatabaseFilters.Add(
                    p => p.ProductCategoryId == info.ProductCategory.ID);
            }
            
            if (info.Name.HasValue())
            {
                PlDatabaseFilters.Add(p => p.Name.Contains(info.Name.Trim(), false));
            }
            
            info.Paging.Clear();
            info.Paging.AddPageSizeOptions(5, 10, 20, 50, 100, 200, 500, "All");
            info.Items = await GetPlSource(info)
                .Select(item => new vm.ProductsList.ListItem(item)).ToList();
        }
        
        [NonAction]
        async Task<IEnumerable<Product>> GetPlSource(vm.ProductsList info, bool all = false)
        {
            var query = Database.Of<Product>().Where(PlDatabaseFilters);
            
            IEnumerable<Product> result = await query.GetList();
            
            result = info.Sort.Apply(result);
            
            result = result.ToList();
            info.Paging.TotalItemsCount = result.Count();
            
            if (all) return result;
            else return result.TakePage(info.Paging);
            return result;
        }
        
        [NonAction]
        public async Task<ActionResult> ExportAs(vm.ProductsList info, Olive.Export.Format mode)
        {
            var exporter = new Olive.Export.Exporter("Products list");
            
            // Add header texts:
            
            // Add data rows:
            
            foreach (var item in await GetPlSource(info, all: true))
            {
                exporter.AddRow();
            }
            
            return File(exporter.Generate(mode).GetUtf8WithSignatureBytes(),
            "text/csv",
            "My Contacts" + exporter.GetFileExtension(mode));
        }
    }
}

namespace ViewModel
{
    [EscapeGCop("Auto generated code.")]
    #pragma warning disable
    [BindingController(typeof(Controllers.ProductsListController))]
    public partial class ProductsList : IViewModel
    {
        public ProductsList()
        {
            Paging = new ListPagination(this, 5) { Prefix = "pl" , UseAjaxGet = true };
            Sort = new ListSortExpression(this) { Prefix = "pl" };
            
            SelectedColumns = new ColumnSelection("pl")
            {
                Options = new List<string> { "Image", "Actions" },
                Default = new List<string> { "Actions" }
            };
        }
        
        [FromRequest("item")]
        public ProductCategory ProductCategoryData { get; set; }
        
        [FromQuery(Name = "pl.s")]
        public ListSortExpression Sort { get; set; }
        
        [FromQuery(Name = "pl.p")]
        public ListPagination Paging { get; set; }
        
        [FromQuery(Name = "pl.c")]
        public ColumnSelection SelectedColumns { get; set; }
        
        // Search filters
        [FromQuery(Name = "pl.ProductCategory")]
        public ProductCategory ProductCategory { get; set; }
        
        [FromQuery(Name = "pl.Name")]
        public string Name { get; set; }
        
        [ReadOnly(true)]
        public List<SelectListItem> ProductCategory_Options = new List<SelectListItem>();
        
        [ReadOnly(true)]
        public List<ListItem> Items = new List<ListItem>();
        
        public partial class ListItem : IViewModel
        {
            public ListItem(Product item) => Item = item;
            
            [ValidateNever]
            public Product Item { get; set; }
        }
    }
}
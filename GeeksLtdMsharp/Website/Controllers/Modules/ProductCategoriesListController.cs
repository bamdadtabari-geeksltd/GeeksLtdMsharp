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
    public partial class ProductCategoriesListController : BaseController
    {
        [HttpPost("ProductCategoriesList/Search")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Search(vm.ProductCategoriesList info)
        {
            await TryUpdateModelAsync(info);
            return View(info);
        }
        
        [HttpPost("ProductCategoriesList/Save")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Save(vm.ProductCategoriesList info, [Bind(Prefix="list.item")] ProductCategory item)
        {
            item.UpdateName(info.Items.First(x=> x.Item.ID == item.ID).Name);
            
            Notify("Product Category Name Updated !!", obstruct: false);
            
            return Do(WindowAction.Refresh);
        }
        
        [HttpPost("ProductCategoriesList/Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(vm.ProductCategoriesList info, [Bind(Prefix="list.item")] ProductCategory item)
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
            
            Do(WindowAction.ShowPleaseWait);
            
            return Do(WindowAction.Refresh);
        }
        
        [HttpPost("ProductCategoriesList/Reload")]
        public async Task<ActionResult> Reload(vm.ProductCategoriesList info)
        {
            return View(info);
        }
        
        [NonAction, OnBound]
        public async Task OnBound(vm.ProductCategoriesList info)
        {
            info.Items = await GetPclSource(info)
            .Select(async item =>
            {
                var listItem = new vm.ProductCategoriesList.ListItem(item);
                await item.CopyDataTo(listItem);
                
                if (Request.IsPost())
                    await TryUpdateModelAsync(listItem, prefix: "pcl.Item-" + item.ID);
                return listItem;
            }
            
            ).ToList();
        }
        
        [NonAction]
        async Task<IEnumerable<ProductCategory>> GetPclSource(vm.ProductCategoriesList info, bool all = false)
        {
            var query = Database.Of<ProductCategory>();
            
            IEnumerable<ProductCategory> result = await query.GetList();
            
            if (info.FullSearch.HasValue())
            {
                var keywords = info.FullSearch.Split(' ').Trim().ToArray();
                result = result.Where(item => item.ToString("F").ContainsAll(keywords, caseSensitive: false));
            }
            
            result = info.Sort.Apply(result);
            
            result = result.ToList();
            info.Paging.TotalItemsCount = result.Count();
            
            if (all) return result;
            else return result.TakePage(info.Paging);
            return result;
        }
    }
}

namespace ViewModel
{
    [EscapeGCop("Auto generated code.")]
    #pragma warning disable
    [BindingController(typeof(Controllers.ProductCategoriesListController))]
    public partial class ProductCategoriesList : IViewModel
    {
        public ProductCategoriesList()
        {
            Paging = new ListPagination(this, 10) { Prefix = "pcl" , UseAjaxPost = true };
            Sort = new ListSortExpression(this) { Prefix = "pcl" , UseAjaxPost = true };
        }
        
        [FromQuery(Name = "pcl.s")]
        public ListSortExpression Sort { get; set; }
        
        [FromQuery(Name = "pcl.p")]
        public ListPagination Paging { get; set; }
        
        // Search filters
        [FromQuery(Name = "pcl.FullSearch")]
        public string FullSearch { get; set; }
        
        [ReadOnly(true)]
        public List<ListItem> Items = new List<ListItem>();
        
        public partial class ListItem : IViewModel
        {
            public ListItem(ProductCategory item) => Item = item;
            
            [ValidateNever]
            public ProductCategory Item { get; set; }
            
            [StringLength(200, ErrorMessage = "Name should not exceed 200 characters.")]
            public string Name { get; set; }
        }
        
        /// <summary>To enable data binding</summary>
        public T The<T>(T model) => model;
    }
}
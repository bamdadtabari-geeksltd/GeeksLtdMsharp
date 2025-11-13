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
    [Authorize(Roles = "Admin")]
    [EscapeGCop("Auto generated code.")]
    #pragma warning disable
    public partial class PropertyPropertiesController : BaseController
    {
        [Route("property/properties")]
        public async Task<ActionResult> Index(vm.PropertiesList info)
        {
            ViewData["LeftMenu"] = "AdminSettingsMenu";
            
            return View(info);
        }
        
        [HttpPost("PropertiesList/Search")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Search(vm.PropertiesList info)
        {
            await TryUpdateModelAsync(info);
            return View(info);
        }
        
        [HttpPost("PropertiesList/Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(vm.PropertiesList info, [Bind(Prefix="list.item")] Property item)
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
        
        [HttpPost("PropertiesList/Reload")]
        public async Task<ActionResult> Reload(vm.PropertiesList info)
        {
            return View(info);
        }
        
        [NonAction, OnBound]
        public async Task OnBound(vm.PropertiesList info)
        {
            info.Items = await GetSource(info)
                .Select(item => new vm.PropertiesList.ListItem(item)).ToList();
        }
        
        [NonAction]
        async Task<IEnumerable<Property>> GetSource(vm.PropertiesList info, bool all = false)
        {
            var query = Database.Of<Property>();
            
            IEnumerable<Property> result = await query.GetList();
            
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
    public partial class PropertiesList : IViewModel
    {
        public PropertiesList()
        {
            Paging = new ListPagination(this, 10) { UseAjaxPost = true };
            Sort = new ListSortExpression(this) { UseAjaxPost = true };
        }
        
        [FromQuery(Name = "s")]
        public ListSortExpression Sort { get; set; }
        
        [FromQuery(Name = "p")]
        public ListPagination Paging { get; set; }
        
        // Search filters
        public string FullSearch { get; set; }
        
        [ReadOnly(true)]
        public List<ListItem> Items = new List<ListItem>();
        
        public partial class ListItem : IViewModel
        {
            public ListItem(Property item) => Item = item;
            
            [ValidateNever]
            public Property Item { get; set; }
        }
    }
}
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
    public partial class AssetController : BaseController
    {
        DatabaseFilters<Asset> DatabaseFilters;
        
        [Route("asset")]
        public async Task<ActionResult> Index(vm.AssetsList info)
        {
            ViewData["LeftMenu"] = "AdminSettingsMenu";
            
            return View(info);
        }
        
        [HttpPost("AssetsList/Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(vm.AssetsList info, [Bind(Prefix="list.item")] Asset item)
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
            
            await TryUpdateModelAsync(info);
            return View(info);
        }
        
        [NonAction, OnBound]
        public async Task OnBound(vm.AssetsList info)
        {
            DatabaseFilters = new DatabaseFilters<Asset>();
            
            info.Type_Options.Clear();
            info.Type_Options.Add(new EmptyListItem("All"));
            info.Type_Options.AddRange(await GetBaseSource(info).Select(x => x.Type).ExceptNull().Distinct());
            
            if (info.Type != null)
            {
                DatabaseFilters.Add(
                    a => a.TypeId == info.Type.ID);
            }
            
            info.Items = await GetSource(info)
                .Select(item => new vm.AssetsList.ListItem(item)).ToList();
        }
        
        [NonAction]
        async Task<IEnumerable<Asset>> GetBaseSource(vm.AssetsList info)
        {
            var query = Database.Of<Asset>().Where(DatabaseFilters);
            
            IEnumerable<Asset> result = await query.GetList();
            
            return result;
        }
        
        [NonAction]
        async Task<IEnumerable<Asset>> GetSource(vm.AssetsList info)
        {
            var result = await GetBaseSource(info);
            
            if (info.FullSearch.HasValue())
            {
                var keywords = info.FullSearch.Split(' ').Trim().ToArray();
                result = result.Where(item => item.ToString("F").ContainsAll(keywords, caseSensitive: false));
            }
            
            return result;
        }
    }
}

namespace ViewModel
{
    [EscapeGCop("Auto generated code.")]
    #pragma warning disable
    public partial class AssetsList : IViewModel
    {
        // Search filters
        public AssetType Type { get; set; }
        
        public string FullSearch { get; set; }
        
        [ReadOnly(true)]
        public List<SelectListItem> Type_Options = new List<SelectListItem>();
        
        [ReadOnly(true)]
        public List<ListItem> Items = new List<ListItem>();
        
        public partial class ListItem : IViewModel
        {
            public ListItem(Asset item) => Item = item;
            
            [ValidateNever]
            public Asset Item { get; set; }
        }
    }
}
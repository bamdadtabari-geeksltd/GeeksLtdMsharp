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
    public partial class AssetTypeController : BaseController
    {
        [Route("asset-type")]
        public async Task<ActionResult> Index(vm.AssetTypesList info)
        {
            ViewData["LeftMenu"] = "AdminSettingsMenu";
            
            return View(info);
        }
        
        [HttpPost("AssetTypesList/Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(vm.AssetTypesList info, [Bind(Prefix="list.item")] AssetType item)
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
        public async Task OnBound(vm.AssetTypesList info)
        {
            info.Items = await GetSource(info)
                .Select(item => new vm.AssetTypesList.ListItem(item)).ToList();
        }
        
        [NonAction]
        async Task<IEnumerable<AssetType>> GetSource(vm.AssetTypesList info)
        {
            var query = Database.Of<AssetType>();
            
            IEnumerable<AssetType> result = await query.GetList();
            
            return result;
        }
    }
}

namespace ViewModel
{
    [EscapeGCop("Auto generated code.")]
    #pragma warning disable
    public partial class AssetTypesList : IViewModel
    {
        [ReadOnly(true)]
        public List<ListItem> Items = new List<ListItem>();
        
        public partial class ListItem : IViewModel
        {
            public ListItem(AssetType item) => Item = item;
            
            [ValidateNever]
            public AssetType Item { get; set; }
        }
    }
}
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
    public partial class DeveloperController : BaseController
    {
        [Route("developer")]
        public async Task<ActionResult> Index(vm.DevelopersList info)
        {
            ViewData["LeftMenu"] = "AdminSettingsMenu";
            
            return View(info);
        }
        
        [HttpPost("DevelopersList/Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(vm.DevelopersList info, [Bind(Prefix="list.item")] Developer item)
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
        }
        
        [NonAction, OnBound]
        public async Task OnBound(vm.DevelopersList info)
        {
            info.Items = await GetSource(info)
                .Select(item => new vm.DevelopersList.ListItem(item)).ToList();
        }
        
        [NonAction]
        async Task<IEnumerable<Developer>> GetSource(vm.DevelopersList info)
        {
            var query = Database.Of<Developer>();
            
            IEnumerable<Developer> result = await query.GetList();
            
            return result;
        }
    }
}

namespace ViewModel
{
    [EscapeGCop("Auto generated code.")]
    #pragma warning disable
    public partial class DevelopersList : IViewModel
    {
        [ReadOnly(true)]
        public List<ListItem> Items = new List<ListItem>();
        
        public partial class ListItem : IViewModel
        {
            public ListItem(Developer item) => Item = item;
            
            [ValidateNever]
            public Developer Item { get; set; }
        }
    }
}
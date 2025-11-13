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
    public partial class ClientController : BaseController
    {
        [Route("client")]
        public async Task<ActionResult> Index(vm.ClientsList info)
        {
            ViewData["LeftMenu"] = "AdminSettingsMenu";
            
            return View(info);
        }
        
        [HttpPost("ClientsList/Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(vm.ClientsList info, [Bind(Prefix="list.item")] Client item)
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
        public async Task OnBound(vm.ClientsList info)
        {
            info.Items = await GetSource(info)
                .Select(item => new vm.ClientsList.ListItem(item)).ToList();
        }
        
        [NonAction]
        async Task<IEnumerable<Client>> GetSource(vm.ClientsList info, bool all = false)
        {
            var query = Database.Of<Client>();
            
            IEnumerable<Client> result = await query.GetList();
            
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
    public partial class ClientsList : IViewModel
    {
        public ClientsList()
        {
            Paging = new ListPagination(this, 5) { UseAjaxGet = true };
            Sort = new ListSortExpression(this);
        }
        
        [FromQuery(Name = "s")]
        public ListSortExpression Sort { get; set; }
        
        [FromQuery(Name = "p")]
        public ListPagination Paging { get; set; }
        
        [ReadOnly(true)]
        public List<ListItem> Items = new List<ListItem>();
        
        public partial class ListItem : IViewModel
        {
            public ListItem(Client item) => Item = item;
            
            [ValidateNever]
            public Client Item { get; set; }
        }
    }
}
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
    public partial class TimeLogController : BaseController
    {
        [Route("time-log")]
        public async Task<ActionResult> Index(vm.TimeLogsList info)
        {
            ViewData["LeftMenu"] = "AdminSettingsMenu";
            
            return View(info);
        }
        
        [HttpPost("TimeLogsList/Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(vm.TimeLogsList info, [Bind(Prefix="list.item")] TimeLog item)
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
        public async Task OnBound(vm.TimeLogsList info)
        {
            info.Items = await GetSource(info)
                .Select(item => new vm.TimeLogsList.ListItem(item)).ToList();
        }
        
        [NonAction]
        async Task<IEnumerable<TimeLog>> GetSource(vm.TimeLogsList info)
        {
            var query = Database.Of<TimeLog>();
            
            IEnumerable<TimeLog> result = await query.GetList();
            
            return result;
        }
    }
}

namespace ViewModel
{
    [EscapeGCop("Auto generated code.")]
    #pragma warning disable
    public partial class TimeLogsList : IViewModel
    {
        [ReadOnly(true)]
        public List<ListItem> Items = new List<ListItem>();
        
        public partial class ListItem : IViewModel
        {
            public ListItem(TimeLog item) => Item = item;
            
            [ValidateNever]
            public TimeLog Item { get; set; }
        }
    }
}
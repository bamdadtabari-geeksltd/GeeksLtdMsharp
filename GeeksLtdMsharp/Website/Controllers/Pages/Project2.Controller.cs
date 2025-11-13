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
    public partial class Project2Controller : BaseController
    {
        [Route("project2")]
        public async Task<ActionResult> Index(vm.Projects2List info)
        {
            ViewData["LeftMenu"] = "AdminSettingsMenu";
            
            return View(info);
        }
        
        [HttpPost("Projects2List/Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(vm.Projects2List info, [Bind(Prefix="list.item")] Project2 item)
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
        public async Task OnBound(vm.Projects2List info)
        {
            info.Items = await GetSource(info)
                .Select(item => new vm.Projects2List.ListItem(item)).ToList();
        }
        
        [NonAction]
        async Task<IEnumerable<Project2>> GetSource(vm.Projects2List info)
        {
            var query = Database.Of<Project2>();
            
            IEnumerable<Project2> result = await query.GetList();
            
            return result;
        }
    }
}

namespace ViewModel
{
    [EscapeGCop("Auto generated code.")]
    #pragma warning disable
    public partial class Projects2List : IViewModel
    {
        [ReadOnly(true)]
        public List<ListItem> Items = new List<ListItem>();
        
        public partial class ListItem : IViewModel
        {
            public ListItem(Project2 item) => Item = item;
            
            [ValidateNever]
            public Project2 Item { get; set; }
        }
    }
}
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
    public partial class ProjectTaskController : BaseController
    {
        [Route("project-task")]
        public async Task<ActionResult> Index(vm.ProjectTaskList info)
        {
            ViewData["LeftMenu"] = "AdminSettingsMenu";
            
            return View(info);
        }
        
        [HttpPost("ProjectTaskList/Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(vm.ProjectTaskList info, [Bind(Prefix="list.item")] ProjectTask item)
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
        public async Task OnBound(vm.ProjectTaskList info)
        {
            info.Items = await GetSource(info)
                .Select(item => new vm.ProjectTaskList.ListItem(item)).ToList();
        }
        
        [NonAction]
        async Task<IEnumerable<ProjectTask>> GetSource(vm.ProjectTaskList info, bool all = false)
        {
            var query = Database.Of<ProjectTask>();
            
            IEnumerable<ProjectTask> result = await query.GetList();
            
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
    public partial class ProjectTaskList : IViewModel
    {
        public ProjectTaskList() => Paging = new ListPagination(this, 10) { UseAjaxGet = true };
        
        [FromQuery(Name = "p")]
        public ListPagination Paging { get; set; }
        
        [ReadOnly(true)]
        public List<ListItem> Items = new List<ListItem>();
        
        public partial class ListItem : IViewModel
        {
            public ListItem(ProjectTask item) => Item = item;
            
            [ValidateNever]
            public ProjectTask Item { get; set; }
        }
    }
}
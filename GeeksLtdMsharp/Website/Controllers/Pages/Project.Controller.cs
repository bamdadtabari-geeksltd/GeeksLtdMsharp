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
    public partial class ProjectController : BaseController
    {
        [Route("project")]
        public async Task<ActionResult> Index(vm.ProjectsList info)
        {
            ViewData["LeftMenu"] = "AdminSettingsMenu";
            
            return View(info);
        }
        
        [HttpPost("ProjectsList/Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(vm.ProjectsList info, [Bind(Prefix="list.item")] Project item)
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
        public async Task OnBound(vm.ProjectsList info)
        {
            info.Items = await GetSource(info)
                .Select(item => new vm.ProjectsList.ListItem(item)).ToList();
        }
        
        [NonAction]
        async Task<IEnumerable<Project>> GetSource(vm.ProjectsList info)
        {
            var query = Database.Of<Project>();
            
            IEnumerable<Project> result = await query.GetList();
            
            return result;
        }
    }
}

namespace ViewModel
{
    [EscapeGCop("Auto generated code.")]
    #pragma warning disable
    public partial class ProjectsList : IViewModel
    {
        [ReadOnly(true)]
        public List<ListItem> Items = new List<ListItem>();
        
        public partial class ListItem : IViewModel
        {
            public ListItem(Project item) => Item = item;
            
            [ValidateNever]
            public Project Item { get; set; }
        }
    }
}
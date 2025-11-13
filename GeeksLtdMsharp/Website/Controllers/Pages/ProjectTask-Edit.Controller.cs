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
    public partial class ProjectTaskEditController : BaseController
    {
        [Route("project-task/edit/{item:Guid?}")]
        public async Task<ActionResult> Index(vm.ProjectTaskEdit info)
        {
            // Remove initial validation messages as well as unintended injected data
            ModelState.Clear();
            
            ViewData["LeftMenu"] = "AdminSettingsMenu";
            
            return View(info);
        }
        
        [HttpPost("ProjectTaskEdit/Save")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Save(vm.ProjectTaskEdit info)
        {
            try
            {
                if (!await SaveInDatabase(info)) return JsonActions(info);
            }
            catch (Olive.Entities.ValidationException ex)
            {
                return Notify(ex.Message, "error");
            }
            
            Notify("Saved successfully.", obstruct: false);
            
            Do(WindowAction.CloseModalRebindParent);
            
            return JsonActions(info);
        }
        
        [NonAction, OnBound]
        public async Task OnBound(vm.ProjectTaskEdit info)
        {
            info.Item = info.Item ?? new ProjectTask();
            
            if (Request.IsGet()) await info.Item.CopyDataTo(info);
        }
        
        [NonAction]
        public async Task<bool> SaveInDatabase(vm.ProjectTaskEdit info)
        {
            if (!ModelState.IsValid(info))
            {
                Notify(ModelState.GetErrors().ToLinesString(), "error");
                return false;
            }
            
            var item = info.Item.IsNew ? info.Item : info.Item.Clone();
            
            await info.CopyDataTo(item); // Read the ViewModel data into the domain object.
            
            using (var scope = Database.CreateTransactionScope())
            {
                try
                {
                    info.Item = await Database.Save(item);
                    
                    scope.Complete();
                    return true;
                }
                catch (Olive.Entities.ValidationException ex)
                {
                    Notify(ex.ToFullMessage(), "error");
                }
                
                return false;
            }
        }
    }
}

namespace ViewModel
{
    [EscapeGCop("Auto generated code.")]
    #pragma warning disable
    public partial class ProjectTaskEdit : IViewModel
    {
        [ValidateNever]
        public ProjectTask Item { get; set; }
        
        [Required, HasDefault]
        public bool Done { get; set; }
        
        [Required]
        [StringLength(200, ErrorMessage = "Title should not exceed 200 characters.")]
        public string Title { get; set; }
        
        [StringLength(500, ErrorMessage = "Description should not exceed 500 characters.")]
        public string Description { get; set; }
    }
}
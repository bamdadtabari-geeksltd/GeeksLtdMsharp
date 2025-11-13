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
    public partial class TimeLogEnterController : BaseController
    {
        [Route("time-log/enter/{item:Guid?}")]
        public async Task<ActionResult> Index(vm.TimeLogForm info)
        {
            // Remove initial validation messages as well as unintended injected data
            ModelState.Clear();
            
            ViewData["LeftMenu"] = "AdminSettingsMenu";
            
            return View(info);
        }
        
        [HttpPost("TimeLogForm/Save")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Save(vm.TimeLogForm info)
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
            
            return AjaxRedirect(Url.ReturnUrl());
        }
        
        [NonAction, OnBound]
        public async Task OnBound(vm.TimeLogForm info)
        {
            info.Item = info.Item ?? new TimeLog();
            
            if (Request.IsGet()) await info.Item.CopyDataTo(info);
            
            info.Project2_Options.Clear();
            info.Project2_Options.Add(new EmptyListItem());
            info.Project2_Options.AddRange(await Database.GetList<Project2>());
            
            info.Developer_Options.Clear();
            info.Developer_Options.Add(new EmptyListItem());
            info.Developer_Options.AddRange(await Database.GetList<Developer>());
        }
        
        [NonAction]
        public async Task<bool> SaveInDatabase(vm.TimeLogForm info)
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
    public partial class TimeLogForm : IViewModel
    {
        [ValidateNever]
        public TimeLog Item { get; set; }
        
        [Required]
        public Project2 Project2 { get; set; }
        
        [Required]
        public Developer Developer { get; set; }
        
        [Required, DataType(DataType.Date)]
        public DateTime? Date { get; set; }
        
        [Time, Required, DataType(DataType.Time), DisplayName("Start time")]
        public TimeSpan StartTime { get; set; }
        
        [Time, Required, DataType(DataType.Time), DisplayName("End time")]
        public TimeSpan EndTime { get; set; }
        
        [StringLength(200, ErrorMessage = "Details should not exceed 200 characters.")]
        public string Details { get; set; }
        
        [ReadOnly(true)]
        public List<SelectListItem> Project2_Options = new List<SelectListItem>();
        
        [ReadOnly(true)]
        public List<SelectListItem> Developer_Options = new List<SelectListItem>();
    }
}
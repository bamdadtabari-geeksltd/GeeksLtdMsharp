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
    public partial class ClientAddInvoiceController : BaseController
    {
        [Route("client/add-invoice/{clientId:Guid?}")]
        public async Task<ActionResult> Index(vm.InvoiceForm info)
        {
            // Remove initial validation messages as well as unintended injected data
            ModelState.Clear();
            
            ViewData["LeftMenu"] = "AdminSettingsMenu";
            
            return View(info);
        }
        
        [HttpPost("InvoiceForm/Save")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Save(vm.InvoiceForm info)
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
        public async Task OnBound(vm.InvoiceForm info)
        {
            info.Item = info.Item ?? new Invoice();
            
            if (Request.IsGet()) await info.Item.CopyDataTo(info);
            
            if (Request.Has("client"))
            {
                info.Client = await Request.Get<Client>("client");
            }
            
            info.Client_Options.Clear();
            info.Client_Options.Add(new EmptyListItem());
            info.Client_Options.AddRange(await Database.GetList<Client>());
        }
        
        [NonAction]
        public async Task<bool> SaveInDatabase(vm.InvoiceForm info)
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
    public partial class InvoiceForm : IViewModel
    {
        [FromRequest("clientId")]
        [ValidateNever]
        public Invoice Item { get; set; }
        
        [Required, CustomBound]
        public Client Client { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime? Date { get; set; }
        
        public decimal? Amount { get; set; }
        
        [StringLength(2500, ErrorMessage = "Description should not exceed 2500 characters.")]
        public string Description { get; set; }
        
        [ReadOnly(true)]
        public List<SelectListItem> Client_Options = new List<SelectListItem>();
    }
}
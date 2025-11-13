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
    [Authorize(Roles = "Admin")]
    [EscapeGCop("Auto generated code.")]
    #pragma warning disable
    public partial class PropertyEnterController : BaseController
    {
        [Route("property/enter/{item:Guid?}")]
        public async Task<ActionResult> Index(vm.PropertyForm info)
        {
            // Remove initial validation messages as well as unintended injected data
            ModelState.Clear();
            
            return View(info);
        }
        
        [HttpPost("PropertyForm/Save")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Save(vm.PropertyForm info)
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
        public async Task OnBound(vm.PropertyForm info)
        {
            info.Item = info.Item ?? new Property();
            
            if (Request.IsGet())
            {
                await info.Item.CopyDataTo(info);
                
                await (await info.Item.Address ?? new Address()).CopyDataTo(info, targetPrefix: "Address_");
            }
        }
        
        [NonAction]
        public async Task<bool> SaveInDatabase(vm.PropertyForm info)
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
                    
                    var itemAddress = (await item.Address)?.Clone() ?? new Address { Property = item };
                    await info.CopyDataTo(itemAddress, sourcePrefix: "Address_");
                    await Database.Save(itemAddress);
                    
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
    public partial class PropertyForm : IViewModel
    {
        [ValidateNever]
        public Property Item { get; set; }
        
        [Required]
        [StringLength(200, ErrorMessage = "Name should not exceed 200 characters.")]
        public string Name { get; set; }
        
        [Required]
        [Range(0, double.MaxValue, ErrorMessage="Price should be 0 or more.")]
        public decimal? Price { get; set; }
        
        [Required]
        [StringLength(200, ErrorMessage = "Owner should not exceed 200 characters.")]
        public string Owner { get; set; }
        
        [Range(0, int.MaxValue, ErrorMessage="Age should be 0 or more.")]
        public int? Age { get; set; }
        
        [Required, DisplayName("Address Line 1")]
        [StringLength(200, ErrorMessage = "Address Line 1 should not exceed 200 characters.")]
        public string Address_AddressLine1 { get; set; }
        
        [Required, DisplayName("Address Line 2")]
        [StringLength(200, ErrorMessage = "Address Line 2 should not exceed 200 characters.")]
        public string Address_AddressLine2 { get; set; }
        
        [Required]
        [StringLength(200, ErrorMessage = "Town should not exceed 200 characters.")]
        public string Address_Town { get; set; }
        
        [Required, DisplayName("Postal Code")]
        [StringLength(200, ErrorMessage = "Postal Code should not exceed 200 characters.")]
        public string Address_PostalCode { get; set; }
    }
}
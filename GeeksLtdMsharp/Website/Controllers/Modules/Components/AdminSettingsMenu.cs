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
using Olive.Security;
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

namespace ViewComponents
{
    [EscapeGCop("Auto generated code.")]
    #pragma warning disable
    public partial class AdminSettingsMenu : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(vm.AdminSettingsMenu info)
        {
            return View(await Bind<vm.AdminSettingsMenu>(info));
        }
    }
}

namespace Controllers
{
    [EscapeGCop("Auto generated code.")]
    #pragma warning disable
    public partial class AdminSettingsMenuController : BaseController
    {
        [NonAction, OnBound]
        public async Task OnBound(vm.AdminSettingsMenu info)
        {
            info.ActiveItem = GetActiveItem(info);
        }
        
        [NonAction]
        public string GetActiveItem(vm.AdminSettingsMenu info)
        {
            var items = new[]
            {
                new MenuItem ("ProductCategories", Url.Index("ProductCategory")),
                new MenuItem ("Products", Url.Index("Product")),
                new MenuItem ("Contacts", Url.Index("Contact")),
                new MenuItem ("Administrators", Url.Index("AdminSettingsAdministrators")),
                new MenuItem ("GeneralSettings", Url.Index("AdminSettingsGeneral")),
                new MenuItem ("ProductSummery", Url.Index("Summary")),
                new MenuItem ("Property", Url.Index("Property")),
                new MenuItem ("Projects", Url.Index("Project")),
                new MenuItem ("ProjectTasks", Url.Index("ProjectTask")),
                new MenuItem ("AssetTypes", Url.Index("AssetType")),
                new MenuItem ("Owners", Url.Index("Owner")),
                new MenuItem ("AssetsList", Url.Index("Asset")),
                new MenuItem ("Clients", Url.Index("Client")),
                new MenuItem ("Projects2", Url.Index("Project2")),
                new MenuItem ("Developers", Url.Index("Developer")),
                new MenuItem ("TimeLogs", Url.Index("TimeLog")),
                new MenuItem ("Employees", Url.Index("Employee")),
                new MenuItem ("Register", Url.Index("Register"))
            };
            
            items.Do(x => x.Url = x.Url.UrlDecode());
            return items.BestMatchToCurrentUrl()?.Key;
        }
    }
}

namespace ViewModel
{
    [EscapeGCop("Auto generated code.")]
    #pragma warning disable
    [BindingController(typeof(Controllers.AdminSettingsMenuController))]
    public partial class AdminSettingsMenu : IViewModel
    {
        public string ActiveItem { get; set; }
    }
}
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
    public partial class PropertyViewController : BaseController
    {
        [Route("property/view/{item:Guid}")]
        public async Task<ActionResult> Index(vm.PropertyView info)
        {
            ViewData["LeftMenu"] = "AdminSettingsMenu";
            
            return View(info);
        }
    }
}

namespace ViewModel
{
    [EscapeGCop("Auto generated code.")]
    #pragma warning disable
    public partial class PropertyView : IViewModel
    {
        [ValidateNever]
        public Property Item { get; set; }
    }
}
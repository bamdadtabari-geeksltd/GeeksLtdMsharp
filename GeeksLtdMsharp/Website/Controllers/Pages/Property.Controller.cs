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
    public partial class PropertyController : BaseController
    {
        [Route("property")]
        public async Task<ActionResult> Index(vm.MainMenu info)
        {
            return Redirect(Url.Index("PropertyProperties"));
            
            ViewBag.Info = info;
            
            return View(ViewBag);
        }
    }
}
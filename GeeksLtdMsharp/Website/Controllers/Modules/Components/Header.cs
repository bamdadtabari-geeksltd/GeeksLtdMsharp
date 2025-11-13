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
    public partial class Header : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(vm.Header info)
        {
            return View(await Bind<vm.Header>(info));
        }
    }
}

namespace Controllers
{
    [EscapeGCop("Auto generated code.")]
    #pragma warning disable
    public partial class HeaderController : BaseController
    {
        [HttpPost("Header/Logout")]
        public async Task<ActionResult> Logout(vm.Header info)
        {
            if (!(User.Identity.IsAuthenticated))
                return new UnauthorizedResult();
            await OAuth.Instance.LogOff();
            
            return Redirect(Url.Index("Login"));
        }
    }
}

namespace ViewModel
{
    [EscapeGCop("Auto generated code.")]
    #pragma warning disable
    [BindingController(typeof(Controllers.HeaderController))]
    public partial class Header : IViewModel
    {
    }
}
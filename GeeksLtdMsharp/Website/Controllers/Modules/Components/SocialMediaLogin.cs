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
    public partial class SocialMediaLogin : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(vm.SocialMediaLogin info)
        {
            return View(await Bind<vm.SocialMediaLogin>(info));
        }
    }
}

namespace Controllers
{
    [EscapeGCop("Auto generated code.")]
    #pragma warning disable
    public partial class SocialMediaLoginController : BaseController
    {
        [HttpPost("SocialMediaLogin/Facebook")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Facebook(vm.SocialMediaLogin info)
        {
            await OAuth.Instance.LoginBy("Facebook");
            
            return JsonActions(info);
        }
        
        [HttpPost("SocialMediaLogin/Google")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Google(vm.SocialMediaLogin info)
        {
            await OAuth.Instance.LoginBy("Google");
            
            return JsonActions(info);
        }
        
        [NonAction, OnBound]
        public async Task OnBound(vm.SocialMediaLogin info)
        {
            info.Item = new User();
        }
    }
}

namespace ViewModel
{
    [EscapeGCop("Auto generated code.")]
    #pragma warning disable
    [BindingController(typeof(Controllers.SocialMediaLoginController))]
    public partial class SocialMediaLogin : IViewModel
    {
        public string Provider { get; set; }
        
        public string Error { get; set; }
        
        [ReadOnly(true)]
        public User Item { get; set; }
    }
}
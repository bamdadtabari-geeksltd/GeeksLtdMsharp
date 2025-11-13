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
    public partial class LoginController : BaseController
    {
        [Route("login")]
        [Route("")]
        public async Task<ActionResult> Index(vm.LoginForm loginForm, vm.SocialMediaLogin socialMediaLogin)
        {
            if (Request.IsAjaxPost())
            {
                return Redirect(Url.CurrentUri().OriginalString);
            }
            
            if (User.Identity.IsAuthenticated)
            {
                return Redirect(Url.Index("LoginDispatch"));
            }
            
            if (Url.ReturnUrl().IsEmpty())
            {
                return Redirect("/login" + "?ReturnUrl=" + "/login");
            }
            
            // Remove initial validation messages as well as unintended injected data
            ModelState.Clear();
            
            ViewBag.LoginForm = loginForm;
            ViewBag.SocialMediaLogin = socialMediaLogin;
            
            return View(ViewBag);
        }
    }
}
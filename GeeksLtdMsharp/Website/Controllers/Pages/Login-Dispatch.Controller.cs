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
    public partial class LoginDispatchController : BaseController
    {
        [Route("login/dispatch")]
        public async Task<ActionResult> Index()
        {
            if (User.IsInRole("Admin"))
            {
                return Redirect(Url.Index("Admin"));
            }
            else
            {
                return Redirect(Url.Index("_401"));
            }
            
            Notify("get out !!!!", obstruct: false);
            
            return new EmptyResult();
        }
    }
}
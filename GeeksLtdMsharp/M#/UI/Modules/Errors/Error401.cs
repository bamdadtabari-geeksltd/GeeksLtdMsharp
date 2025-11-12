using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MSharp;

namespace Modules
{
    public class Error401 : GenericModule
    {
        public Error401()
        {
            Markup(@"
                <div class=""error-page text-center"">
                    <h1 class=""display-1"">401</h1>
                    <h2>Unauthorized</h2>
                    <p class=""lead"">You do not have permission to view this page.</p>
                    <a href=""/login"" class=""btn btn-primary mt-3"">Go to Login Page</a>
                </div>
            ");
        }
    }
}

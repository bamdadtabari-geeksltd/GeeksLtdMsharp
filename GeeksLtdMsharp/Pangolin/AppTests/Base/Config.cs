using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Internal;

namespace AppTests.Base
{
    public static class Config
    {
        public const string LocalPort = "51491";
        public const string Localhost = $"http://localhost:{LocalPort}";
        public const string Hosted = "https://app.fakedommain.com";
        public const string Email = "oiver@fakemail.com";
        public const string Password = "test";
    }
}

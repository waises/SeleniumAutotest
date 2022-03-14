using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using Newtonsoft.Json;

namespace Automatisation
{
    public class BrowserFactory 
    {
        private static IWebDriver webDriver;
        private static IOptions options;

        private static string baseUrl = "steam.com";
        private static string browser = "";
        
        public static void Init()
        {
            
            //webDriver.Manage().Window.Maximize();
            //options.AddArgument(@"--incognito");
        }
    }
}

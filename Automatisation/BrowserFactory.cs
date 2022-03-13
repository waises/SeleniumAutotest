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
    public class BroesrFactory
    {
        private static IWebDriver webDriver;
        private static ChromeOptions chromeOptions;

        private static string baseUrl = "steam.com";
        private static string browser = "";
        public static IWebDriver WebDriverOptions;
        
        public static void Init()
        {
            switch (browser)
            {
                case "Chrome":
                    webDriver = new ChromeDriver();
                    break;
                case "Firefox":
                    webDriver = new FirefoxDriver();
                    break;
            }
            
            webDriver.Manage().Window.Maximize();
            chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument(@"--incognito");
        }
    }
}

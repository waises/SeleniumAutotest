using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace Automatisation
{
    public class MainPage
    {
        public static string baseUrl;
        public static WebDriverWait wait;
        public static IWebElement About_bttn;

        public MainPage()
        {
            baseUrl = "https://store.steampowered.com/";

        }
        public static string BaseUrl()
        {
            return baseUrl ;
            
        }

    }
}

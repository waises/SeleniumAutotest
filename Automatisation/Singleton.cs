using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace Automatisation
{
    public class Singleton
        
    {
        private static Singleton instance = null;
        private WebDriver webDriver;
        protected Singleton()
        {
            webDriver = new ChromeDriver();
    }       
            public static Singleton getInstance()
        {
            if (instance == null)  instance = new Singleton();
            return instance;
        }
     
    }

}

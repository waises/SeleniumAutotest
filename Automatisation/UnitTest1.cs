using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace Automatisation
{
    public class Tests : BrowserFactory
    {
        IWebDriver driver ;//пробный
       // ChromeOptions options;

        [SetUp]
        public void Setup()
        {
            // options = new ChromeOptions();
            //  options.AddArgument(@"--incognito");

            //                              initialize of driver(Singleton)
            driver = new ChromeDriver();
        }

        [Test]
        public void Test1()

        {
            //                                      
            //                                      Creating options        

            //                                          Open page
            driver.Navigate().GoToUrl("https://store.steampowered.com/");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement SearchResult = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//a[@class='menuitem' and contains(@href, 'about')]")));

            SearchResult.Click();

         //   IWebElement SearchResult_online = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//div[@class= 'online_stat']/following-sibling::text()[1]")));
          //  IWebElement SearchResult_ingame = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//div[@class= 'online_stat']/following-sibling::text()[2]")));

          //  Assert.IsTrue(Convert.ToInt32(SearchResult_online) < Convert.ToInt32(SearchResult_ingame), "»гроков в игре больше или столько же чем онлайн");


            IWebElement Shop = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//a[@class= 'menuitem supernav' and contains(text(), 'ћј√ј«»Ќ')]")));
            Shop.Click();
            
            //options.AddArgument(@"--lang engl");
            // driver = new ChromeDriver(options);
            // driver.Manage().Window.Maximize();


        }
        [Test]
        public void Test2()

        {

            //                                      
            //                                      Creating options        

            //                                          Open page


            driver.Navigate().GoToUrl("https://store.steampowered.com/");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            Actions mouseAction = new Actions(driver);
            IWebElement SearchResult_1 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//div[@class = 'tab  flyout_tab']//*")));
            mouseAction.MoveToElement(SearchResult_1).Perform();
            //action.Release(elem);
            IWebElement SearchResult = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//a[@class='popup_menu_item' and contains(@href, 'topsellers')]")));
            
            SearchResult.Click();
        }
        [TearDown]
        public void AfterTestSuit()
        {
           driver.Close();
        }
    }
}
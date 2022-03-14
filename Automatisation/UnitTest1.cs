using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

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

             object SearchResult_about = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//div[@class= 'online_stat']/following-sibling::text()[1]")));
            string text = SearchResult_about.ToString();
            Console.WriteLine(text);
            //IWebElement SearchResult_about = driver.(By.XPath("//div[@class= 'online_stat']/following-sibling::text()"));
            //wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[@class= 'online_stat']/following-sibling::text()")));
            //string text =  SearchResult_about.Text;
            //Assert.IsTrue(text == "O steam", $"{text}");
            //options.AddArgument(@"--lang engl");
            // driver = new ChromeDriver(options);
            // driver.Manage().Window.Maximize();

            //  driver.Navigate().GoToUrl("https://store.steampowered.com/");
            //  Assert.IsTrue(driver.Title=="Добро пожаловать в Steam", $"{driver.Title}");


            //  IWebElement about_bttn = driver.FindElement(By.XPath("//a[@class='menuitem' and contains(@href, 'about')]"));
            //  string about_text = about_bttn.Text;

            //Assert.IsTrue(about_text == "О STEAM", $"problem with {about_bttn}");
            // about_bttn.Click();

            // IWebElement online_players = driver.FindElement(By.XPath("//div[@class= 'online_stat']/following-sibling::text()[1]"));
            // string online_text = online_players.Text;
            // Assert.IsTrue(online_text == "2141241",$"{online_text}");



        }
        [TearDown]
        public void AfterTestSuit()
        {
           driver.Close();
        }
    }
    class Singletom
    {

    }
}
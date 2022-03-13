using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace Automatisation
{
    public class Tests
    {
        IWebDriver driver ;
        ChromeOptions options;

        [SetUp]
        public void Setup()
        {
            options = new ChromeOptions();
            options.AddArgument(@"--incognito");
            
            
        }

        [Test]
        public void Test1()
        {
            //options.AddArgument(@"--lang engl");
            driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl("https://store.steampowered.com/");
            Assert.IsTrue(driver.Title=="Добро пожаловать в Steam", $"{driver.Title}");


            IWebElement about_bttn = driver.FindElement(By.XPath("//a[@class='menuitem' and contains(@href, 'about')]"));
            string about_text = about_bttn.Text;


            Assert.IsTrue(about_text == "О STEAM", $"problem with {about_bttn}");
            about_bttn.Click();

            IWebElement online_players = driver.FindElement(By.XPath("//div[@class= 'online_stat']//*"));
            string online_text = online_players.Text;
            Assert.IsTrue(online_text == "2141241",$"{online_text}");
            


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
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SleniumTests
{
    [TestClass]
    public class UnitTest1
    {
        IWebDriver driver;

        [TestInitialize]
        public void IntiateBrowser()
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            //chromeOptions.AddArgument("headless");
            driver = driver = new ChromeDriver(chromeOptions);
        }

        [TestMethod]
        public void NaviagteToURL()
        {
            driver.Navigate().GoToUrl("http://www.google.com");
        }

        [TestCleanup]
        public void CloseAllBrowsers()
        {
            driver.Close();
            driver.Quit();
        }
    }
}

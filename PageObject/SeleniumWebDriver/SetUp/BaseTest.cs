using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;


namespace SeleniumWebDriver
{
    public class BaseTest
    {
        protected IWebDriver webDriver;


        [SetUp]
        public void StartBrowser()
        {
            webDriver = new ChromeDriver();

            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(200);
            webDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(100);
            webDriver.Manage().Window.Maximize();
            webDriver.Navigate().GoToUrl("https://wizzair.com/#/");
        }

        [TearDown]
        public void CloseBrowser()  
        {
            webDriver.Quit();
            webDriver.Dispose();
        }
        protected IWebElement GetWebElement(string xPath)
        {
            return webDriver.FindElement(By.XPath(xPath));
        }
    }
}
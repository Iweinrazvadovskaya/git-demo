using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using OpenQA.Selenium.Support;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
//using AShotNet.Coordinates;
//using AShotNet;
using OpenQA.Selenium.Firefox;

namespace SeleniumWebDriver
{
    public class BaseTest
    {
        protected IWebDriver webDriver;


        [SetUp]
        public void StartBrowser()
        {
            webDriver = new FirefoxDriver();
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            webDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60);
            webDriver.Manage().Window.Maximize();
            webDriver.Navigate().GoToUrl("https://wizzair.com/#/");
        }

        protected void MakeScreenshotWhenFail(Action action)
        {
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
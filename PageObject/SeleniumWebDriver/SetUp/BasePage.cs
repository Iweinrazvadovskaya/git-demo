using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;

namespace SeleniumWebDriver.SetUp
{
   public abstract class BasePage
   {
        protected IWebDriver webDriver;

        protected void InitPage<T>(IWebDriver webDriver, T page) where T : BasePage
        {
            PageFactory.InitElements(webDriver, page);
        }

   }
   
   
}

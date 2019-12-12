using System;
using System.Collections.Generic;
using System.Text;
using SeleniumWebDriver.SetUp;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Support.UI;
namespace SeleniumWebDriver.Pages
{
    class HomePage : BasePage
    {
        private const string SearchButtonSelector =
   "//*[@class = 'flight-search-surf-button rf-button--medium rf-button--primary flight-search__panel__cta-btn']";
        private const string DestinationFieldSelector = "//INPUT[@id='search-arrival-station']";
        private const string errorMessage =
            "//*[@class = 'content-error-newfrontend_kb__text']";

        [FindsBy(How = How.XPath, Using = SearchButtonSelector)]
        public IWebElement SearchButton;

        [FindsBy(How = How.XPath, Using = DestinationFieldSelector)]
        public IWebElement DestinationField;

        [FindsBy(How = How.XPath, Using = errorMessage)]
        public IWebElement ErrorMessage;

        public HomePage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
            InitPage(webDriver, this);
        }
        public HomePage WriteIntoDestinationField(string text)
        {
            DestinationField.Clear();
            DestinationField.SendKeys(text);
            return new HomePage(this.webDriver);
        }
        public HomePage ClickToSearchButton()
        {
            SearchButton.Click();
            return new HomePage(this.webDriver);
        }


    }
}

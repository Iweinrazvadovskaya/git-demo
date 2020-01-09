using System;
using System.Collections.Generic;
using System.Text;
using SeleniumWebDriver.SetUp;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Support.UI;
using SeleniumWebDriver.Model;
namespace SeleniumWebDriver.Pages
{
    public class HomePage : BasePage
    {
        #region SearchForm

        [FindsBy(How = How.XPath, Using = "//*[@class = 'flight-search__panel__fieldset flight-search__panel__fieldset--cta-btn']")]
        private IWebElement SearchButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class = 'rf-input__error']")]
        private IWebElement ErrorTextDestinationOrigin { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id = 'search-arrival-station']")]
        private IWebElement InputDestinationCity { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id = 'search-departure-station']")]
        private IWebElement InputOriginCity { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class = 'locations-container__no-results']")]
        private IWebElement ErrorBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id = 'search-passenger']")]
        private IWebElement InputPersons { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class = 'stepper__button stepper__button--add']")]
        private IWebElement AddInfaltButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class = 'rf-input__error']")]
        private IWebElement ErrorRegistrationText { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class = 'arrival-input__swap-stations__icon icon swap-stations']")]
        private IWebElement InversionButton { get; set; }
        #endregion


        public HomePage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
            InitPage(webDriver, this);
        }


        public bool FindWithoutDestination()
        {
            SearchButton.Click();
            return ErrorTextDestinationOrigin.Displayed;
        }

        public bool SearchWithoutArrival()
        {
            InputOriginCity.SendKeys("Tirana");
            return ErrorBox.Displayed;
        }

        public bool InputOneAdultOneChild()
        {
            InputOriginCity.SendKeys("Budapest");
            InputDestinationCity.SendKeys("Vienna");
            InputPersons.Click();
            IList<IWebElement> all = webDriver.FindElements(By.CssSelector(".stepper__button.stepper__button--add"));

            String[] allText = new String[all.Count];
            int i = 0;
            foreach (IWebElement element in all)
            {
                allText[i++] = element.Text;
            }
            all[2].Click();
            string disabled = all[2].GetAttribute("disabled");
            if (disabled == null)
            {
                return false;
            }
            else return true;
        }

        public bool NewSerchCleaner()
        {
            InputOriginCity.SendKeys("Budapest");
            InputDestinationCity.SendKeys("Vienna");
            IList<IWebElement> all = webDriver.FindElements(By.CssSelector(".content__link1"));

            String[] allText = new String[all.Count];
            int i = 0;
            foreach (IWebElement element in all)
            {
                allText[i++] = element.Text;
            }
            all[2].Click();
            if (InputOriginCity.Text == "" && InputDestinationCity.Text=="")
            {
                return true;
            }
            else return false;
        }

        public bool InvertionOriginDestination()
        {
            InputOriginCity.SendKeys("Budapest");
            InputDestinationCity.SendKeys("Vienna");
            IList<IWebElement> all = webDriver.FindElements(By.CssSelector(".content__link1"));
            String[] allText = new String[all.Count];
            int i = 0;
            foreach (IWebElement element in all)
            {
                allText[i++] = element.Text;
            }
            all[1].Click();
            if (webDriver.Url== "https://wizzair.com/en-gb/flights/timetable") return true;
            else return false;
        }
    }
}

using System.Text;
using SeleniumWebDriver.SetUp;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Support.UI;
using SeleniumWebDriver.Model;

namespace SeleniumWebDriver.Pages
{
    public class DynamicStatisticPage : BasePage
    {
        #region DynamicControl
        [FindsBy(How = How.XPath, Using = "//span[@class=y-button__text']")]
        private IWebElement DynamicFindButton;
        #endregion

        public DynamicStatisticPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        public bool FindTicketByStatistic()
        {
            return new SearchResultPage(this.webDriver).IsDisplaySearchResult();
        }
    }
}

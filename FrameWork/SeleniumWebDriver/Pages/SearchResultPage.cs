using OpenQA.Selenium;
using SeleniumExtras.PageObjects;


namespace SeleniumWebDriver.Pages
{
    public class SearchResultPage
    {
        #region SearchResult
        [FindsBy(How = How.XPath, Using = "//span[@id='gws-flights-results__best_flights_heading']")]
        private IWebElement bestSearchResultElement;
        #endregion

        public SearchResultPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        public bool IsDisplaySearchResult()
        {
            return bestSearchResultElement.Displayed;
        }
    }
}

using System;
using System.Threading;
using NUnit.Framework;

namespace SeleniumWebdriver.Tests
{
    [TestFixture]
    public class SearchTest : TestBase
    {
        private const string ExpectedErrorText =
            "Введённые вами параметры поиска некорректны.\r\nПожалуйста, измените параметры поиска и запустите новый поиск.";
       
        [Test]
        public void SearchWithEqualDepartureAndDestinationPlace()
        {
                var searchButton = GetWebElement("//*[@class = 'flight-search-surf-button rf-button--medium rf-button--primary flight-search__panel__cta-btn']");
                var originToText = GetWebElement("//INPUT[@id=search-departure-station']");
            var destinationToText = GetWebElement("//INPUT[@id='search-arrival-station']");
            originToText.SendKeys("Billund");
                destinationToText.SendKeys("Billund");
                searchButton.Click();
                var errorMessage = GetWebElement("//*[@class = 'locations-container__no-results']");
                Assert.IsNull(errorMessage);
        }



         

        [Test]
        public void SearchWithoutDestination()
        {
            var searchButton = GetWebElement("//BUTTON[@type='submit'][text()='НАЙТИ']");
            var destinationText = GetWebElement("//INPUT[@id='twidget-destination']");
            searchButton.Click();
            Thread.Sleep(TimeSpan.FromSeconds(1));
            var sdfg = destinationText.GetAttribute("title");
            Assert.AreEqual("Заполните это поле.", destinationText.GetAttribute("Title"));
        }
    }
}

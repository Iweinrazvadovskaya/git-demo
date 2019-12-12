using System;
using System.Threading;
using NUnit.Framework;
using SeleniumWebDriver.Pages;
using SeleniumWebDriver.SetUp;

namespace SeleniumWebDriver
{
    [TestFixture]
    class SearchTest : BaseTest
    {
        private const string ExpectedErrorText = "Уточните пункт назначения";

        [Test]
        public void SearchWithDestinationAndPointOfDeparture()
        {

            HomePage homePage = new HomePage(webDriver);
            var searchResultPage = homePage.WriteIntoDestinationField("Минск,Беларусь")
                .ClickToSearchButton();
            Assert.AreEqual(ExpectedErrorText,searchResultPage.ErrorMessage.Text);
        }

        [Test]
        public void SearchWithoutDestination()
        {
            HomePage homePage = new HomePage(webDriver);
            var searchResultPage = homePage
                .ClickToSearchButton();
            Assert.AreEqual(ExpectedErrorText, searchResultPage.ErrorMessage.Text);
           
        }
    }
}

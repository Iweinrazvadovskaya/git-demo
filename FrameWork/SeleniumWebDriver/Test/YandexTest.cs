using System;
using System.Threading;
using NUnit.Framework;
using SeleniumWebDriver.Pages;
using SeleniumWebDriver.SetUp;
using SeleniumWebDriver.Service;
using SeleniumWebDriver.Logging;

namespace SeleniumWebDriver
{
    [TestFixture]
    class YandexTest : BaseTest
    {
        [Test]
        [Category("WorkTest")]
        public void SearchWithOutDestinationOrigin()
        {
            HomePage home = new HomePage(webDriver);
            bool resultError = home.FindWithoutDestination();
            Assert.IsTrue(!resultError);
        }

        [Test]
        [Category("WorkTest")]
        public void SearchWithOutDestination()
        {
            HomePage home = new HomePage(webDriver);
            bool resultError = home.SearchWithoutArrival();
            Assert.IsTrue(resultError);
        }

        [Test]
        [Category("WorkTest")]
        public void OneAdultOneInfalt()
        {
            HomePage home = new HomePage(webDriver);
            bool resultError = home.InputOneAdultOneChild();
            Assert.IsTrue(resultError);
        }

        [Test]
        [Category("WorkTest")]
        public void NewSearchClean()
        {
            HomePage home = new HomePage(webDriver);
            bool resultError = home.NewSerchCleaner();
            Assert.IsTrue(resultError);
        }

        [Test]
        [Category("WorkTest")]
        public void CitiesInversion()
        {
            HomePage home = new HomePage(webDriver);
            bool resultError = home.InvertionOriginDestination();
            Assert.IsTrue(resultError);
        }

    }
}

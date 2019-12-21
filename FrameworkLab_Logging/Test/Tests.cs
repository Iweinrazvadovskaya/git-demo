using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace FrameworkLab
{
	[TestFixture]
	public class Tests
	{
		private IWebDriver webDriver;

		[SetUp]
		public void OpenBrowserAndGoToSite()
		{
			Logger.InitLogger();
		}

		[TearDown]
		public void StopBrowser()
		{
			if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
			{
				CreatorOfScreenshot.TakeScreenshot();
			}
			DriverSingleton.CloseDriver();
		}

		[Test]
		public void SearchTicketsWithoutDateInput()
		{
			FlightsPage flightsPage = new FlightsPage()
				.EnterDepartureCity("Vilnius")
				.EnterDestinationCity("Vena")
				.Enter();
			Assert.AreEqual("You shouls pick a date", flightsPage.GetDepartDateErrorMessage());

            Logger.Log.Info("Search tickets without date test");
        }

        [Test]
        public void EnterEqualDepartureAndDestinationCity()
        {
            string city = "Vena";

            FlightsPage flightsPage = new FlightsPage()
                .EnterDepartureCity(city)
                .EnterDestinationCity(city)
                .EnterDepartDate("22 December")
                .Enter();
            Assert.AreEqual("Origin and destination cannot be the same", flightsPage.GetDestinationErrorMessage());

            Logger.Log.Info(" Enter Equal Departure And Destination City Test");
        }

        [Test]
		public void SearchTicketsWithoutDestinationInput()
		{
			FlightsPage flightsPage = new FlightsPage()
				.EnterDepartureCity("Vilnius")
				.EnterDepartDate("22 December")
				.Enter();
			Assert.AreEqual("Select destination", flightsPage.GetDestinationErrorMessage());

            Logger.Log.Info(" Search Tickets Without Destination Input Test");
        }

		[Test]
		public void AreEqualInputInfoAndInfoInSearchPage()
		{
			string expextedDepartureCity = "Vilnius";
			string expectedDestinationCity = "Vena";
			string expectedDepartDate = "22 December";

			FlightsPage flightsPage = new FlightsPage()
				.EnterDepartureCity(expextedDepartureCity)
				.EnterDestinationCity(expectedDestinationCity)
				.EnterDepartDate(expectedDepartDate)
				.Enter();

			string[] expectedList = { expextedDepartureCity, expectedDestinationCity, expectedDepartDate };
			string[] actualList = { flightsPage.GetDepartureCity(), flightsPage.GetDestinationCity(), flightsPage.GetDepartDate() };

			Assert.AreEqual(expectedList, actualList);
            Logger.Log.Info(" Are Equal Input Info And Info In Search Page Test");
        }


        [Test]
        public void ChangeDepartureAndDestination()
        {
            string expextedDepartureCity = "Vilnius";
            string expectedDestinationCity = "Vena";
            string expectedDepartDate = "22 December";
            FlightsPage flightsPage = new FlightsPage()
              .EnterDepartureCity(expextedDepartureCity)
              .EnterDestinationCity(expectedDestinationCity)
              .EnterDepartDate(expectedDepartDate)
              .ClickChangeButton();

              Assert.AreEqual("Vena", flightsPage.GetDepartureCity);

            Logger.Log.Info(" Change departure and destination Test");
        }


        [Test]
        public void SetFourInfant()
        {
            string expextedDepartureCity = "Vilnius";
            string expectedDestinationCity = "Vena";
            string expectedDepartDate = "22 December";
            FlightsPage flightsPage = new FlightsPage()
              .EnterDepartureCity(expextedDepartureCity)
              .EnterDestinationCity(expectedDestinationCity)
              .EnterDepartDate(expectedDepartDate)
              .InfantIncrement(4)
              .AdultDecrement()
              .Enter();

            Assert.AreEqual("", flightsPage.GetErrorTooltip().Text);

            Logger.Log.Info(" Set Four Infant Test");
        }


        [Test]
		public void AreAqualHotelCityAndDestinationCity()
		{
			string expectedDestinationCity = "Vilnius";
			string expectedDepartDate = "22" +
                " December";

			HotelPage hotelPage = new FlightsPage()
				.EnterDepartureCity("Vena")
				.EnterDestinationCity(expectedDestinationCity)
				.EnterDepartDate(expectedDepartDate)
				.ClickHotelButton();

			string[] expectedList = { expectedDestinationCity, expectedDepartDate };
			string[] actualList = { hotelPage.GetDestinationCity(), hotelPage.GetDepartDate() };

			Assert.AreEqual(expectedList, actualList);

            Logger.Log.Info(" Are aqual hotel city and destination Test");
        }

    }
}
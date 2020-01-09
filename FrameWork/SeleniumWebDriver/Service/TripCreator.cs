using System;
using System.Collections.Generic;
using System.Text;
using SeleniumWebDriver.Model;

namespace SeleniumWebDriver.Service
{
    class TripCreator
    {
        public static Trip WithAllProperties()
        {
            return new Trip(TestDataReader.GetData("DepartureCity"), TestDataReader.GetData("ArrivalCity"), TestDataReader.GetData("FutureDate"), TestDataReader.GetData("PastDate"));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumWebDriver.Model
{
    public class Trip
    {
       public string CityFrom { get; set; }
       public string CityTo { get; set; }
       public string DateFrom { get; set; }
       public string DateTo { get; set; }

        public Trip(string cityFrom,string cityTo,string dateFrom,string dateTo)
        {
            CityFrom = cityFrom;
            CityTo = cityTo;
            DateFrom = dateFrom;
            DateTo = dateTo;

        }
    }
}

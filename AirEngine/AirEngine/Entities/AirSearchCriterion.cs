using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AirEngine.Entities
{
    public class AirSearchCriterion
    {
        public string ArrivalAirportCode { get; private set; }
        public string DepartureAirportCode { get; private set; }
        public AirSearchCriterion(string arrivalAirportCode, string departureAirportCode)
        {
            this.ArrivalAirportCode = arrivalAirportCode;
            this.DepartureAirportCode = departureAirportCode;
        }
    }
}

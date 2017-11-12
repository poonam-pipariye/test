using AirEngine.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirEngine.BusinessLogic
{
    public class AirSearch
    {

        internal static AirSearchRS SearchFlight(AirSearchRQ doSearchRQ)
        {
            return new AirSearchRS
            {
                SessionId = Guid.NewGuid(),
                FlightNumber=3175,
                ArrivalDate=DateTime.Now.AddDays(20.0),
                DepartureDate=DateTime.Now.AddDays(23.0)
            };
        }
    }
}
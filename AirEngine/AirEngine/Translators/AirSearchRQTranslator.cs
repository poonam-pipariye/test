using AirEngine.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirEngine.Translators
{
    public class AirSearchRQTranslator
    {
        public static AirSearchRQ ToDataObject(AirEngine.DataContracts.AirSearchRQ searchRQ)
        {
            return new AirSearchRQ
            {
                SessionId=searchRQ.SessionId,
                searchCriterion = new AirSearchCriterion(searchRQ.ArrivalAirportCode,searchRQ.DepartureAirportCode)
          
            };
        }
    }
}
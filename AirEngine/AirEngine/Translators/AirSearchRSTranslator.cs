using AirEngine.DataContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirEngine.Translators
{
    public class AirSearchRSTranslator
    {
        public static AirSearchRS ToDataTransferObject(AirEngine.Entities.AirSearchRS searchRS)
        {
            return new AirSearchRS
            {
                SessionId = searchRS.SessionId,
                FlightNumber = searchRS.FlightNumber,
                ArrivalDate = searchRS.ArrivalDate,
                DepartureDate = searchRS.DepartureDate
            };
        }
    }
}
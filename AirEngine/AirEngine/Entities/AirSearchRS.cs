using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirEngine.Entities
{
    public class AirSearchRS
    {
        public Guid SessionId { get; set; }
        public int FlightNumber { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime ArrivalDate { get; set; }
    }
}
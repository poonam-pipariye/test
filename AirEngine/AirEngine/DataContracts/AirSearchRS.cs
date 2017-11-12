using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace AirEngine.DataContracts
{
    [DataContract]
    public class AirSearchRS
    {
        [DataMember]
        public Guid SessionId { get; set; }
        [DataMember]
        public int FlightNumber { get; set; }
        [DataMember]
        public DateTime DepartureDate { get; set; }
        [DataMember]
        public DateTime ArrivalDate { get; set; }
    }
}
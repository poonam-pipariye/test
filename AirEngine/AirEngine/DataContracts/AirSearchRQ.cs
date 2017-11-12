using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace AirEngine.DataContracts
{
    [DataContract]
    public class AirSearchRQ
    {
        [DataMember]
        public Guid SessionId { get; set; }
        [DataMember]
        public string ArrivalAirportCode { get; private set; }
        [DataMember]
        public string DepartureAirportCode { get; private set; }
        //[DataMember]
        //public AirSearchCriterion searchCriterion { get; set; }
    }
}
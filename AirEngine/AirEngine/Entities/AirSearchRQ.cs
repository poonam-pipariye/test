using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirEngine.Entities
{
    public class AirSearchRQ
    {
        public Guid SessionId { get; set; }
        public AirSearchCriterion searchCriterion { get; set; }
    }
}
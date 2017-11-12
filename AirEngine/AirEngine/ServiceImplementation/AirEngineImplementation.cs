using AirEngine.BusinessLogic;
using AirEngine.DataContracts;
using AirEngine.ServiceContracts;
using AirEngine.Translators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirEngine.ServiceImplementation
{
    public class AirEngineImplementation:IAirEngine
    {
        public AirSearchRS Search(AirSearchRQ searchRQ)
        {
            var doSearchRQ = AirSearchRQTranslator.ToDataObject(searchRQ);
            var searchResult = AirSearch.SearchFlight(doSearchRQ);
            var dtoSearchRS = AirSearchRSTranslator.ToDataTransferObject(searchResult);
            return new AirSearchRS();
            
        }
    }
}
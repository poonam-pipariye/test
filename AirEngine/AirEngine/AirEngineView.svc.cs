using AirEngine.BusinessLogic;
using AirEngine.DataContracts;
using AirEngine.ServiceContracts;
using AirEngine.Translators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AirEngine
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AirEngineView" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select AirEngineView.svc or AirEngineView.svc.cs at the Solution Explorer and start debugging.
    public class AirEngineView : IAirEngine
    {
        public AirSearchRS Search(AirSearchRQ searchRQ)
        {
            var doSearchRQ = AirSearchRQTranslator.ToDataObject(searchRQ);
            var searchResult = AirSearch.SearchFlight(doSearchRQ);
            var dtoSearchRS = AirSearchRSTranslator.ToDataTransferObject(searchResult);
            return dtoSearchRS;
        }
    }
}

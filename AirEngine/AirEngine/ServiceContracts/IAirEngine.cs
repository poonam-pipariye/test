using AirEngine.DataContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;          
using System.Threading.Tasks;

namespace AirEngine.ServiceContracts
{
    [ServiceContract]
    public interface IAirEngine
    {
        [OperationContract]
         AirSearchRS Search(AirSearchRQ searchRQ);
    }
}

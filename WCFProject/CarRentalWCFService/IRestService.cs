using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CarRentalWCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IRestService" in both code and config file together.
    [ServiceContract]
    public interface IRestService
    {
        // complicated to request because of JSON Date formats
        [OperationContract]
        [WebInvoke(Method = "POST",
            UriTemplate = "GetAvailableCarsByDates",
            BodyStyle = WebMessageBodyStyle.Wrapped,
            RequestFormat = WebMessageFormat.Json,          
            ResponseFormat = WebMessageFormat.Json)]
        List<int> GetAvailableCarsByDates(DateTime fromDate, DateTime toDate);

        // an easy GET example to make sure REST API is working
        [OperationContract]
        [WebGet(UriTemplate = "GetAllCars",
            BodyStyle = WebMessageBodyStyle.Wrapped,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        List<Car> GetAllCars();
    }
}

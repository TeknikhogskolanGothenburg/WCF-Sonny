using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace CarRentalWCFService
{
    [MessageContract(IsWrapped = true, WrapperName = "CarRequestObject", WrapperNamespace = "http://Sonnyspage.com/Car")]
    public class CarRequest
    {
        [MessageHeader(Namespace = "http://Sonnyspage.com/Car")]
        public string LicenseKey { get; set; }
        [MessageBodyMember(Namespace = "http://Sonnyspage.com/Car")]
        public List<int> CarIds { get; set; }
    }

    [MessageContract(IsWrapped = true, WrapperName = "CarInfoObject", WrapperNamespace = "http://Sonnyspage.com/Car")]
    public class CarInfo
    {
        public CarInfo()
        {

        }

        public CarInfo(Car car)
        {
            this.Id = car.Id;
            this.Brand = car.Brand;
            this.Model = car.Model;
            this.Year = car.Year;
            this.RegNr = car.RegNr;
        }

        [MessageBodyMember(Order = 1, Namespace = "http://Sonnyspage.com/Car")]
        public int Id { get; set; }
        [MessageBodyMember(Order = 2, Namespace = "http://Sonnyspage.com/Car")]
        public string Brand { get; set; }
        [MessageBodyMember(Order = 3, Namespace = "http://Sonnyspage.com/Car")]
        public string Model { get; set; }
        [MessageBodyMember(Order = 4, Namespace = "http://Sonnyspage.com/Car")]
        public int Year { get; set; }
        [MessageBodyMember(Order = 5, Namespace = "http://Sonnyspage.com/Car")]
        public string RegNr { get; set; }
    }



    [DataContract]
    public class Car
    {
        [DataMember(Order = 1)]
        public int Id { get; set; }
        [DataMember(Order = 2)]
        public string Brand { get; set; }
        [DataMember(Order = 3)]
        public string Model { get; set; }
        [DataMember(Order = 4)]
        public int Year { get; set; }
        [DataMember(Order = 5)]
        public string RegNr { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Net.Security;

namespace CarRentalWCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICarService" in both code and config file together.
    [ServiceContract]
    public interface ICarService
    {
        [OperationContract]
        void RemoveCar(string RegNr);

        [OperationContract]
        void AddCar(CarInfo car);

        [OperationContract]
        List<CarInfo> GetCarsByIds(CarRequest request);

        [OperationContract]
        void AddCustomer(Customer customer);

        [OperationContract(ProtectionLevel = ProtectionLevel.Sign)]
        void RemoveCustomer(Customer customer);

        [OperationContract(ProtectionLevel = ProtectionLevel.EncryptAndSign)]
        void UpdateCustomer(Customer customer);

        [OperationContract]
        void CreateBooking(Booking booking);

        [OperationContract]
        void RemoveBooking(Booking booking);
    }
}

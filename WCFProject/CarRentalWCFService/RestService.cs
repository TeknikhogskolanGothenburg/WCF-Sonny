using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BL;
using Domain;

namespace CarRentalWCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "RestService" in both code and config file together.
    public class RestService : IRestService
    {
        public List<Car> GetAllCars()
        {
            CarMethods carService = new CarMethods();

            var carList = carService.GetAllCars();
            var newCarList = new List<Car>();

            foreach(Domain.Car c in carList)
            {
                newCarList.Add(new Car
                {
                    Id = c.Id,
                    Brand = c.Brand,
                    Model = c.Model,
                    Year = c.Year,
                    RegNr = c.RegNr
                });
            }

            return newCarList;
        }

        public List<int> GetAvailableCarsByDates(DateTime fromDate, DateTime toDate)
        {
            CarMethods carService = new CarMethods();
            return carService.GetAllAvailable(fromDate, toDate);
        }


    }
}

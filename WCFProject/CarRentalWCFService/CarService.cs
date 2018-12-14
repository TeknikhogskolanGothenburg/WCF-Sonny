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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CarService" in both code and config file together.
    public class CarService : ICarService
    {
        public void RemoveCar(string RegNr)
        {
            var carService = new CarMethods();
            carService.Remove(RegNr);
        }

        public void AddCar(CarInfo car)
        {
            var carService = new CarMethods();

            var newCar = new Domain.Car
            {
                Id = car.Id,
                Brand = car.Brand,
                Model = car.Model,
                Year = car.Year,
                RegNr = car.RegNr
            };

            carService.Add(newCar);
        }

        public List<CarInfo> GetCarsByIds(CarRequest request)
        {
            if(request.LicenseKey != "Passcode")
            {
                throw new FaultException("Wrong License Key");
            }

            CarMethods carService = new CarMethods();

            var tempCarList = carService.GetById(request.CarIds);

            var carList = new List<Car>();

            foreach (Domain.Car c in tempCarList)
            {
                carList.Add(new Car
                {
                    Id = c.Id,
                    Brand = c.Brand,
                    Model = c.Model,
                    Year = c.Year,
                    RegNr = c.RegNr
                });
            }

            var carListResult = new List<CarInfo>();

            foreach(Car c in carList)
            {
                carListResult.Add(new CarInfo(c));
            }
            
            return carListResult;
        }

        public void AddCustomer(Customer customer)
        {
            var customerService = new CustomerMethods();

            var newCustomer = new Domain.Customer
            {
                Id = customer.Id,
                Firstname = customer.Firstname,
                Lastname = customer.Lastname,
                Telephone = customer.Telephone,
                Email = customer.Email             
            };

            customerService.Add(newCustomer);
        }

        public void RemoveCustomer(Customer customer)
        {
            CustomerMethods customerService = new CustomerMethods();

            var removedCustomer = new Domain.Customer
            {
                Id = customer.Id,
                Firstname = customer.Firstname,
                Lastname = customer.Lastname,
                Telephone = customer.Telephone,
                Email = customer.Email
            };
            customerService.Remove(removedCustomer);
        }

        public void UpdateCustomer(Customer customer)
        {
            var customerService = new CustomerMethods();

            var newCustomer = new Domain.Customer
            {
                Id = customer.Id,
                Firstname = customer.Firstname,
                Lastname = customer.Lastname,
                Telephone = customer.Telephone,
                Email = customer.Email
            };

            customerService.Update(newCustomer);
        }

        public void CreateBooking(Booking booking)
        {
            BookingMethods bookingService = new BookingMethods();

            var newBooking = new Domain.Booking
            {
                Id = booking.Id,
                CarId = booking.CarId,
                CustomerId = booking.CustomerId,
                FromDate = booking.FromDate,
                ToDate = booking.ToDate,
                IsReturned = booking.IsReturned
            };


            bookingService.Create(newBooking);
        }

        public void RemoveBooking(Booking booking)
        {
            BookingMethods bookingService = new BookingMethods();

            var removedBooking = new Domain.Booking
            {
                Id = booking.Id,
                CarId = booking.CarId,
                CustomerId = booking.CustomerId,
                FromDate = booking.FromDate,
                ToDate = booking.ToDate,
                IsReturned = booking.IsReturned
            };
            bookingService.Remove(removedBooking);
        }

        
    }
}

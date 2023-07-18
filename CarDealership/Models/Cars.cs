using System;
using System.Collections.Generic;

namespace CarDealership.Models
{
    public class Car
    {
        public int Year { get; set; }
        public string Make { get; set; }
        public string VehicleModel { get; set; }
        public string Color { get; set; }

        private static List<Car> _availableVehicles = new List<Car> { };

        public Car(int year, string make, string vehicleModel, string color)

        {

            Year = year;
            Make = make;
            VehicleModel = vehicleModel;
            Color = color;
            _availableVehicles.Add(this);
        }

        public static List<Car> GetAll()
        {
            return _availableVehicles;
        }

        public static void ClearAll()
        {
            _availableVehicles.Clear();
        }
    }
}
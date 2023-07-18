using System;
using System.Collections.Generic;

namespace CarDealership.Models
{
    public class Car
    {
        public string Year { get; set; }
        public string Make { get; set; }
        public string VehicleModel { get; set; }
        
        private static List<Car> _instances = new List<Car> { };

        public Car(string year, string make, string vehicleModel)

        {
            
            Year = year;
            Make = make;
            VehicleModel = vehicleModel;
            _instances.Add(this);
        }

        public static List<Car> GetAll()
        {
            return _instances;
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }
    }
}
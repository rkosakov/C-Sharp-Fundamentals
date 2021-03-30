using System;
using System.Collections.Generic;
using System.Linq;

namespace VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Catalog> catalogs = new List<Catalog>();

            string input = Console.ReadLine();
            Catalog catalog = new Catalog();

            while (input != "end")
            {
                string[] elements = input.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);

                string vehicleType = elements[0];
                string brand = elements[1];
                string model = elements[2];
                string data = elements[3];

                if (vehicleType == "Car")
                {
                    catalog.Cars.Add(new Car
                    {
                        Brand = brand,
                        Model = model,
                        HoursePower = data
                    });
                }
                else if (vehicleType == "Truck")
                {
                    catalog.Trucks.Add(new Truck
                    {
                        Brand = brand,
                        Model = model,
                        Weight = data
                    });
                }

                input = Console.ReadLine();
            }

            if (catalog.Cars.Count > 0)
            {
                Console.WriteLine("Cars:");

                foreach (Car car in catalog.Cars.OrderBy(car => car.Brand))
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HoursePower}hp");
                }
            }

            if(catalog.Trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");

                foreach (Truck truck in catalog.Trucks.OrderBy(truck => truck.Brand))
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }

            }


        }
    }

    class Truck
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public string Weight { get; set; }
    }

    class Car
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public string HoursePower { get; set; }
    }

    class Catalog
    {
        public List<Truck> Trucks { get; set; }

        public List<Car> Cars { get; set; }

        public Catalog()
        {
            Cars = new List<Car>();
            Trucks = new List<Truck>();
        }
    }


}

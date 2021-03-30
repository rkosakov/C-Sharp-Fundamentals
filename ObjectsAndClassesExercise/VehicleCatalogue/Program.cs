using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            string input = String.Empty;


            while ((input = Console.ReadLine()) != "End")
            {
                string[] elements = input.Split();

                string type = elements[0];
                string model = elements[1];
                string color = elements[2];
                double horsePower = double.Parse(elements[3]);

                Vehicle vehicle = new Vehicle(type, model, color, horsePower);

                vehicles.Add(vehicle);



            }

            string command = String.Empty;

            while ((command = Console.ReadLine()) != "Close the Catalogue")
            {
                Console.WriteLine(vehicles.FirstOrDefault(x => x.Model == command).ToString());


            }

            var cars = vehicles.FindAll(x => x.Type == "car");
            var hoursePoerCars = cars.Sum(c => c.HoursePower);
            var averagePowerCars = hoursePoerCars / cars.Count;
            var trucks = vehicles.FindAll(x => x.Type == "truck");
            var horsePowerTruck = trucks.Sum(t => t.HoursePower);
            var averagePowerTruck = horsePowerTruck / trucks.Count;

            if (cars.Count == 0)
            {
                averagePowerCars = 0;
            }
            if (trucks.Count == 0)
            {
                averagePowerTruck = 0;
            }

            Console.WriteLine($"Cars have average horsepower of: {averagePowerCars:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {averagePowerTruck:f2}.");
        }
    }

    public class Vehicle
    {
        public string Type { get; set; }
        public string Model { get; set; }

        public string Color { get; set; }

        public double HoursePower { get; set; }

        public Vehicle(string type, string model, string color, double horsePower)
        {
            this.Type = type;
            this.Model = model;
            this.Color = color;
            this.HoursePower = horsePower;
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();

            if (this.Type == "car")
            {
                str.AppendLine($"Type: Car");

            }
            else
            {
                str.AppendLine($"Type: Truck");
            }
            str.AppendLine($"Model: {this.Model}");
            str.AppendLine($"Color: {this.Color}");
            str.AppendLine($"Horsepower: {this.HoursePower}");

            return str.ToString().TrimEnd();


        }



    }


}

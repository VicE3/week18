using System;

namespace cChall4
{
    class Program
    {
        static void Main(string[] args) 
        {
            Vehicle dreamCar = new Vehicle("Truck", 4, 2009, "Toyota");
            Vehicle nightmareCar = new Vehicle("car", 4, 2004, "The one I currently own");

			Console.WriteLine(dreamCar.Model);
            Console.WriteLine(nightmareCar.Model);
        }
    }
        public class Vehicle
        {
            public string Type { get; set; }
	        public int Tires { get; set; }
	        public int Year { get; set; }
	        public string Model { get; set; }


        public Vehicle(string type, int tires, int year, string model)
        {
            Type = type;
            Tires = tires;
            Year = year;
            Model = model;

          

        }
    
    }
    
	}

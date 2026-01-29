using System;

namespace VehicleExample
{
    public abstract class Vehicle
    {
        protected string make;
        protected string model;
        protected int modelYear;
        protected double price;

        public Vehicle()
        {
            make = "Unknown";
            model = "Unknown";
            modelYear = 0;
            price = 0.0;
        }

        public Vehicle(string make, string model, int modelYear, double price)
        {
            this.make = make;
            this.model = model;
            this.modelYear = modelYear;
            this.price = price;
        }

        public virtual void PrintInformation()
        {
           Console.WriteLine("Vehicle Information:");
            Console.WriteLine($"Make: {make}");
            Console.WriteLine($"Model: {model}");
            Console.WriteLine($"Model Year: {modelYear}");
            Console.WriteLine($"Price: {price:C}");
            Console.WriteLine();
        }
    }
}

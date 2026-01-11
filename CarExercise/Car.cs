using System;

namespace CarExercise
{
    internal class Car
    {
        private string brand;
        private double speed;
        public Car()
        {
            brand = "Unknown";
            speed = 0.0;
        }

        public void AskData()
        {
            Console.Write("Type in a car brand: ");
            brand = Console.ReadLine();

            Console.Write("Give a speed for the car (km/h): ");
            string input = Console.ReadLine();

            if (!double.TryParse(input, out speed))
            {
                Console.WriteLine("Unknown input! Speed set to 0.");
                speed = 0.0;
            }
        }
        public void ShowCarInfo()
        {
            Console.WriteLine($"Car: {brand}, Speed: {speed:F1} km/h");
        }
        public void Accelerate(double change)
        {
            if (change < 0)
            {
                Console.WriteLine("Error: Negative acceleration is not allowed!");
                return;
            }

            speed += change;
            Console.WriteLine($"Accelerated {change:F1} km/h, new speed: {speed:F1} km/h");
        }
        public void Brake()
        {
            if (speed <= 0)
            {
                Console.WriteLine("The car has already stopped.");
                return;
            }

            double reduction = speed * 0.10;
            speed -= reduction;

            if (speed < 0) speed = 0;

            Console.WriteLine($"Braked, speed decreased by {reduction:F1} km/h");
            Console.WriteLine($"New speed: {speed:F1} km/h");
        }
    }
}
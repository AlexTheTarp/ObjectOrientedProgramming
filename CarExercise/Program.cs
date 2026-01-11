using System;
using System.Collections.Generic;
using System.Text;

namespace CarExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car \n");

            Car car1 = new Car();
            Car car2 = new Car();

            Console.WriteLine("First car:");
            car1.AskData();
            Console.WriteLine();

            Console.WriteLine("Second car:");
            car2.AskData();
            Console.WriteLine();

            Console.WriteLine("\nStart:");
            car1.ShowCarInfo();
            car2.ShowCarInfo();
            Console.WriteLine();

            Console.WriteLine("Accelerating the cars.");
            car1.Accelerate(30.5);
            car2.Accelerate(45.0);
            car1.Accelerate(15.0);
            Console.WriteLine();

            Console.WriteLine("After acceleration:");
            car1.ShowCarInfo();
            car2.ShowCarInfo();
            Console.WriteLine();

            Console.WriteLine("Braking");
            car1.Brake();
            car2.Brake();
            car2.Brake();
            Console.WriteLine();

            Console.WriteLine("Finish:");
            car1.ShowCarInfo();
            car2.ShowCarInfo();

            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}

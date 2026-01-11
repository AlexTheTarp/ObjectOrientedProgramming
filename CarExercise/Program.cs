using System;
using System.Collections.Generic;
using System.Text;

namespace CarExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Autotesti - Tehtävä ===\n");

            Car car1 = new Car();
            Car car2 = new Car();

            Console.WriteLine("Ensimmäinen auto:");
            car1.AskData();
            Console.WriteLine();

            Console.WriteLine("Toinen auto:");
            car2.AskData();
            Console.WriteLine();

            Console.WriteLine("\nAlkutilanne:");
            car1.ShowCarInfo();
            car2.ShowCarInfo();
            Console.WriteLine();

            Console.WriteLine("Kiihdytetään autoja...");
            car1.Accelerate(30.5);
            car2.Accelerate(45.0);
            car1.Accelerate(15.0);
            Console.WriteLine();

            Console.WriteLine("Kiihdytyksen jälkeen:");
            car1.ShowCarInfo();
            car2.ShowCarInfo();
            Console.WriteLine();

            Console.WriteLine("Jarrutetaan...");
            car1.Brake();
            car2.Brake();
            car2.Brake();
            Console.WriteLine();

            Console.WriteLine("Lopputilanne:");
            car1.ShowCarInfo();
            car2.ShowCarInfo();

            Console.WriteLine("\nPaina mitä tahansa näppäintä lopettaaksesi...");
            Console.ReadKey();
        }
    }
}

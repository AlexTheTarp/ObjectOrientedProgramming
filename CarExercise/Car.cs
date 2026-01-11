using System;

namespace CarExercise
{
    internal class Car
    {
        private string brand;
        private double speed;
        public Car()
        {
            brand = "Tuntematon";
            speed = 0.0;
        }

        public void AskData()
        {
            Console.Write("Anna auton merkki: ");
            brand = Console.ReadLine();

            Console.Write("Anna auton nopeus (km/h): ");
            string input = Console.ReadLine();

            if (!double.TryParse(input, out speed))
            {
                Console.WriteLine("Virheellinen syöte! Nopeus asetetaan arvoksi 0.");
                speed = 0.0;
            }
        }
        public void ShowCarInfo()
        {
            Console.WriteLine($"Auto: {brand}, Nopeus: {speed:F1} km/h");
        }
        public void Accelerate(double change)
        {
            if (change < 0)
            {
                Console.WriteLine("Virhe: Negatiivinen kiihdytys ei ole sallittu!");
                return;
            }

            speed += change;
            Console.WriteLine($"Kiihdytettiin {change:F1} km/h → uusi nopeus: {speed:F1} km/h");
        }
        public void Brake()
        {
            if (speed <= 0)
            {
                Console.WriteLine("Auto on jo pysähdyksissä.");
                return;
            }

            double reduction = speed * 0.10;
            speed -= reduction;

            if (speed < 0) speed = 0;

            Console.WriteLine($"Jarrutettiin → nopeus väheni {reduction:F1} km/h");
            Console.WriteLine($"Uusi nopeus: {speed:F1} km/h");
        }
    }
}
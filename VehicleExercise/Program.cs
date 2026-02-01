using VehicleExample;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8; //Tämä on tässä koska muuten euro mekrkit näkyvät kysymys merkkeinä.

        Console.WriteLine("Basic");
        Vehicle vehicle1 = new Car("Toyota", "Camry", 2020, 25000.0, "2.5L", "Sedan", 4);
        Car car1 = new Car("Honda", "Civic", 2019, 20000.0, "1.8L", "Hatchback", 5);

        vehicle1.PrintInformation();
        car1.PrintInformation();

        Console.WriteLine("ToString and Equals");
        Car car2 = new Car("Honda", "Civic", 2019, 21000.0, "1.8L", "Sedan", 4);
        Car car3 = new Car("Ford", "Focus", 2021, 22000.0, "2.0L", "Hatchback", 5);

        Console.WriteLine(car1);
        Console.WriteLine(car2);
        Console.WriteLine(car3);
        Console.WriteLine();

        Console.WriteLine(car1.Equals(car2));
        Console.WriteLine(car1.Equals(car3));

        Console.WriteLine("Truck and Type Casting");
        Truck truck1 = new Truck("Volvo", "FH16", 2022, 150000.0, "16L", "Heavy Duty", 2, 40000.0, 35.0);
        Truck truck2 = new Truck("Scania", "R730", 2023, 160000.0, "16.4L", "Long Haul", 2, 45000.0, 38.0);

        truck1.PrintInformation();
        truck2.PrintInformation();
        Console.WriteLine($"Consumption per 200 km: {truck1.CalculateConsumption(200):F2} L\n");

        Car carFromTruck = truck1;
        Console.WriteLine("Truck1 as Car:");
        Console.WriteLine(carFromTruck);
        Console.WriteLine();
        
        Truck truckFromCar = carFromTruck as Truck;
        if (truckFromCar != null)
        {
            truckFromCar.PrintInformation();
        }
        else
        {
            Console.WriteLine("Casting failed: Not a Truck.");
        }
        Console.WriteLine();

        Car regularCar = new Car("Tesla", "Model 3", 2024, 40000.0, "Electric", "Sedan", 4);
        Truck failedTruck = regularCar as Truck;
        Console.WriteLine(failedTruck == null
            ? "Casting Car → Truck failed (as expected)."
            : "Unexpected success.");

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
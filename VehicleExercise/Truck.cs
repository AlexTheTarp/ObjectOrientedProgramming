using VehicleExample;

public class Truck : Car
{
    protected double load; 
    protected double consumption;

    public Truck() : base()
    {
        load = 0.0;
        consumption = 0.0;
    }

    public Truck(string make, string model, int modelYear, double price, string engine, string type, int doors, double load, double consumption)
     : base(make, model, modelYear, price, engine, type, doors)
    {
        this.load = load;
        this.consumption = consumption;
    }

    public double CalculateConsumption(double distance)
    {
        return (consumption / 100) * distance;
    }
    
    public override void PrintInformation()
    {
        base.PrintInformation();
        Console.WriteLine($"Load: {load} kg");
        Console.WriteLine($"Consumption: {consumption} L/100 km");
        Console.WriteLine($"Total for 100 km: {CalculateConsumption(100):F2} L");
        Console.WriteLine();
    }
}
using VehicleExample;

public class Car : Vehicle
{
    protected string engine;
    protected string type;
    protected int doors;

    public Car() : base()
    {
        engine = "N/A";
        type = "N/A";
        doors = 0;
    }
    public Car(string make, string model, int modelYear, double price, string engine, string type, int doors)
     : base(make, model, modelYear, price)
    {
        this.engine = engine;
        this.type = type;
        this.doors = doors;
    }

    public override void PrintInformation()
    {
        base.PrintInformation();
        Console.WriteLine($"Engine: {engine}");
        Console.WriteLine($"Type: {type}");
        Console.WriteLine($"Doors: {doors}");
        Console.WriteLine();
    }

    public override string ToString()
    {
        return $"{make}, {model}, {modelYear}, {type}, {engine}, {doors} doors, {price:C}";
    }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }
        Car other = (Car)obj;
        return make == other.make && model == other.model && modelYear == other.modelYear;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(make, model, modelYear);
    }
}
using ShapesExample;

public class Circle : Shape
{
    public double Radius { get; set; }
    
    public Circle(double radius, string color) : base(color)
    {
        Radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }

    public override void GetInfo()
    {
        Console.WriteLine($"Circle | Radius: {Radius:F2} Color: {Color,-10} Area: {GetArea():F2}");
    }
}

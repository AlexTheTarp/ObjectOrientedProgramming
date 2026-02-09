using ShapesExample;

public class Triangle : Shape
{
    public double Base { get; set; }
    public double Height { get; set; }

    public Triangle(double baseLength, double height, string color) : base(color)
    {
        Base = baseLength;
        Height = height;
    }

    public override double GetArea()
    {
        return (Base * Height) / 2;
    }

    public override void GetInfo()
    {
        Console.WriteLine($"Triangle | Base: {Base:F2} Height: {Height:F2} Color: {Color,-10} Area: {GetArea():F2}");
    }
}

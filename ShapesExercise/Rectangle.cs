using ShapesExample;

public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height, string color) : base(color)
    {
        Width = width;
        Height = height;
    }

    public override double GetArea()
    {
        return Width * Height;
    }

    public override void GetInfo()
    {
        Console.WriteLine($"Rectangle | Width: {Width:F2} Height: {Height:F2} Color: {Color, -10} Area: {GetArea():F2}");
    }
}

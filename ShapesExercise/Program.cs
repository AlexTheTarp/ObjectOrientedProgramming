using ShapesExample;
class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>
        {
            new Circle(5.0, "Red"),
            new Rectangle(4.0, 6.0, "Blue"),
            new Triangle(5.0, 8.0, "Green"),
            new Circle(3.5, "Yellow"),
            new Rectangle(7.0, 2.0, "Red"),
            new Triangle(10.0, 3.0, "Blue")
        };

        Console.WriteLine("\n All shapes");
        foreach (var shape in shapes)
        {
            shape.GetInfo();
        }

        Console.WriteLine("\n Press enter to continue");
        Console.ReadLine();

        shapes.Sort();

        Console.WriteLine("\n All shapes in order by surface area");
        foreach (var shape in shapes)
        {
            shape.GetInfo();
        }

        Console.WriteLine("\n Press enter to continue");
        Console.ReadLine();

        Console.WriteLine("\n Only red shapes");
        foreach (var shape in shapes)
        {
            if (shape.Color.Equals("Red", StringComparison.OrdinalIgnoreCase))
            {
                shape.GetInfo();
            }
        }

        Console.WriteLine("\n Press enter to continue");
        Console.ReadLine();

        Console.WriteLine("\n Only circle shapes");
        foreach (var shape in shapes)
        {
            if (shape is Circle)
            {
                shape.GetInfo();
            }
        }

        Console.WriteLine("\n End of program");
    }
}
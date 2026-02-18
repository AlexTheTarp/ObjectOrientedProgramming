using TankExercise;

class program
{
    static void Main(string[] args)
    {
        Tank tank1 = new Tank("VESI", 100);
        Tank tank2 = new Tank("RYPSIÖLJY,", 100);
        Tank tank3 = new Tank("OLIIVIÖLJY", 150);

        Console.WriteLine("-- Säiliöiden luominen");
        Console.WriteLine();
        Console.WriteLine("Tulostetaan säiliöiden lähtötilanne");
        Console.WriteLine(tank1);
        Console.WriteLine(tank2);
        Console.WriteLine(tank3);

        Console.WriteLine();
        Console.WriteLine("-- Säiliöihin lisääminen");
        
        try
        {
            Console.WriteLine(tank1.AddToTank(110));
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message); 
        }

        Console.WriteLine(tank1.AddToTank(100));

        Console.WriteLine(tank2.AddToTank(70));

        Console.WriteLine(tank3.AddToTank(-50));

        Console.WriteLine();
        Console.WriteLine("-- Säiliöistä poistaminen");

        Console.WriteLine(tank1.RemoveFromTank(80));

        try
        {
            Console.WriteLine(tank2.RemoveFromTank(80));
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        Console.WriteLine(tank2.RemoveFromTank(70));

        Console.WriteLine(tank3.RemoveFromTank(-150));

        Console.WriteLine();
        Console.WriteLine("-- Säiliöiden tyhjennys");
        tank1.ClearTank();
        tank2.ClearTank();
        tank3.ClearTank();

        Console.WriteLine();
        Console.WriteLine("-- Tulostetaan säiliöiden lopputilanne");
        Console.WriteLine(tank1);
        Console.WriteLine(tank2);
        Console.WriteLine(tank3);

        Console.ReadKey();
    }
}

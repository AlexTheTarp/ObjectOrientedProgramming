using InterfaceExersice;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Interface\n");

        Console.WriteLine("Products");
        var products = new List<Product>
        {
            new Product("Laptop", 1299.90, 3),
            new Product("Phone", 899.00, 5),
            new Product("Headphones", 199.90, 10)
        };

        foreach (var p in products)
        {
            Console.WriteLine(p);
                Console.WriteLine($"  Matches \"Phone\": {p.MatchesName("Phone")}");
        }
        Console.WriteLine();

        Console.WriteLine("Customers");
        var customers = new List<Customer>
        {
            new Customer("Alice", 900.0),
            new Customer("Bob", 1500.0),
            new Customer("Charlie", 2500.0)
        };

        foreach (var c in customers)
        {
            Console.WriteLine(c);
                Console.WriteLine($"  Matches \"Bob\": {c.MatchesName("Bob")}");
        }
        Console.WriteLine();

       var store = new Store("TechStore Oy", 250000);

        foreach (var p in products) store.AddProduct(p);
        foreach (var c in customers) store.AddCustomer(c);

        store.PrintProducts();
        store.PrintCustomers();
        Console.WriteLine(store);

        var books = new List<Literature.Book>
        {
            new Literature.Book("C# Advanced", "Paavo Räisänen", 59.90),
            new Literature.Book("OOP Basics", "John Doe", 29.90),
            new Literature.Book("Clean Code", "Robert Martin", 45.00)
        };

        books.ForEach(Console.WriteLine);

        books.Sort();

        books.ForEach(Console.WriteLine);

        Console.ReadKey();
    }
}

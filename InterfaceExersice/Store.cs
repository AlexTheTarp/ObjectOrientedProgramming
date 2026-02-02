using InterfaceExersice;
using static Customer;

public class Store : IProducts, ICustomers
{
    private string name;
    private List<Product> products = new List<Product>();
    private List<Customer> customers = new List<Customer>();

    public Store(string name)
    {
        this.name = name;
    }

    public double Revenue => products.Sum(p => p.CalculateTotal());

    public override string ToString()
    {
        return $"Store: {name}, Revenue: {Revenue:C}, Customers: {customers.Count}, Products: {products.Count}";
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }
    public void PrintProducts()
    {
        Console.WriteLine($"Products in store ({products.Count})");
        double totalValue = 0;
        foreach (var p in products)
        {
            Console.WriteLine(p.ToString());
            totalValue += p.CalculateTotal();
        }
        Console.WriteLine($"Total products value: {totalValue:C}");
        Console.WriteLine();
    }
    public void AddCustomer(Customer customer)
    {
        customers.Add(customer);
    }
    public void PrintCustomers()
    {
        Console.WriteLine($"Customers in store ({customers.Count})");
        double totalBonus = 0;
        foreach (var c in customers)
        {
            Console.WriteLine(c.ToString());
            totalBonus += c.GetBonus();
        }
        Console.WriteLine($"Total customer bonuses: {totalBonus:C}");
        Console.WriteLine();
    }
}
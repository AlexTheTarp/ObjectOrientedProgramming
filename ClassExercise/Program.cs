using CompanyExercise;
using System;

namespace ClassExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Company Class\n");

            Company company1 = new Company(
                "TechNova Oy",
                "Hämeenkatu 10, 33100 Tampere",
                "+358 40 123 4567",
                450000.0,
                380000.0
            );

            Company company2 = new Company(
                "Small Bakery Ltd",
                "Satakunnankatu 5, 33210 Tampere",
                "+358 50 987 6543",
                120000.0,
                115000.0
            );

            Company companyCopy = new Company(company1);

            Console.WriteLine("Original company 1:");
            Console.WriteLine(company1.GetFinancialStatus());
            Console.WriteLine();

            Console.WriteLine("Original company 2:");
            Console.WriteLine(company2.GetFinancialStatus());
            Console.WriteLine();

            Console.WriteLine("Copy of company 1:");
            Console.WriteLine(companyCopy.GetFinancialStatus());
            Console.WriteLine();

            Console.WriteLine("Changing outcome of the copy does not affect the original:");
            companyCopy.outcome = 500000.0;
            Console.WriteLine("Original after copy change:");
            Console.WriteLine(company1.GetFinancialStatus());
            Console.WriteLine();
            Console.WriteLine("Modified copy:");
            Console.WriteLine(companyCopy.GetFinancialStatus());

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

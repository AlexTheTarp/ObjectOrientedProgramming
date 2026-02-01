using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace InterfaceExersice
{
    public interface ICustomer
    {
        bool MatchesName(string name);
        double GetBonus();
    }

    public class Customer : ICustomer
    {
        private string name;
        private double purchases;

        public Customer(string name, double purchases)
        {
            this.name = name;
            this.purchases = purchases;
        }

        public bool MatchesName(string value)
        {
            return name.Equals(value, StringComparison.OrdinalIgnoreCase);
        }

        public double GetBonus()
        {
            if (purchases <= 1000)
            {
                return purchases * 0.02;
            }
            else if (purchases <= 2000)
            {
                return purchases * 0.03;
            }
            else
            {
                return purchases * 0.05;
            }
        }

        public override string ToString()
        {
            return $"Customer: {name}, Purchases: {purchases}, Bonus: {GetBonus():C}";
        }
    }
    
    public interface ICustomers
    {
        void AddCustomer(Customer customer);
        void PrintCustomers();
    }
}

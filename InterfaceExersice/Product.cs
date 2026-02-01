using System;
using System.Collections.Generic;

namespace InterfaceExersice
{
    public interface IProduct
    {
        bool MatchesName(string value);
        double CaculateTotal();
    }

    public class Product : IProduct
    {
        private string name;
        private double price;
        private int count;

        public Product(string name, double price, int count)
        {
            this.name = name;
            this.price = price;
            this.count = count;
        }

        public bool MatchesName(string value)
        {
            return name.Equals(value, StringComparison.OrdinalIgnoreCase);
        }

        public double CaculateTotal()
        {
            return price * count;
        }

        public override string ToString()
        {
            return $"Product: {name}, Price: {price:C}, Count: {count}, Total: {CaculateTotal():C}";
        }
    }

    public interface IProducts
    {
        void AddProduct(Product product);
        void PrintProducts();
    }
}

using InterfaceExersice;

namespace Literature
{
public class Book : IComparable<Book>    
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }

        public Book(string name, string author, double price)
        {
            Name = name;
            Author = author;
            Price = price;
        }
         public int CompareTo(Book? other)
        {
            if (other == null) return 1;
            return other is null ? 1 : Price.CompareTo(other.Price);
        }

        public override string ToString()
        {
            return $"{Name} by {Author} - Price: {Price}";
        }
    }
}

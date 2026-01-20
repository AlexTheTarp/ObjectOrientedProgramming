using System;

namespace BookAndAuthorExercise
{
    public class Book
    {
        private string name;
        private string author;
        private string publisher;
        private double price;
        private string isbn;
        public static string theme = "Literature";
        private const int ISBN_LENGTH = 13;
        private const string ISBN_PREFIX = "978";

        public Book()
        {
            name = "Unknown";
            author = "Unknown";
            publisher = "Unknown";
            price = 0.0;
            isbn = "9780000000000";
        }

        public Book(string name, string author, string publisher, double price, string isbn)
        {
            this.name = name;
            this.author = author;
            this.publisher = publisher;
            Price = price;
            ISBN = isbn;
        }

        public double Price
        {
            get => price;
            set
            {
                if (value > 30.0)
                {
                    price = value * 0.9;
                    Console.WriteLine($"Price over 30 → 10% discount applied: {value:C} → {price:C}");
                }
                else
                {
                    price = value;
                }
            }
        }

        public string ISBN
        {
            get => isbn;
            set
            {
                if (value?.Length == ISBN_LENGTH && value.StartsWith(ISBN_PREFIX) && long.TryParse(value, out _))
                {
                    isbn = value;
                }
                else
                {
                    throw new ArgumentException(
                        $"Invalid ISBN: must be exactly {ISBN_LENGTH} digits starting with '{ISBN_PREFIX}'");
                }
            }
        }

        public string Author => author;

        public void GetBookDetails(string isbnToCheck)
        {
            if (isbn == isbnToCheck)
            {
                Console.WriteLine($"Book Details (ISBN: {isbn}):");
                Console.WriteLine($"Title: {name}");
                Console.WriteLine($"Author: {author}");
                Console.WriteLine($"Publisher: {publisher}");
                Console.WriteLine($"Price: {price:C}");
                Console.WriteLine($"Theme: {theme}");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"ISBN mismatch: expected {isbnToCheck}, got {isbn}");
            }
        }

        public static void ChangeTheme(string newTheme)
        {
            theme = newTheme;
            Console.WriteLine($"Theme changed for all books: {newTheme}");
        }

        public override string ToString()
        {
            return $"{name} by {author} – {publisher} – {price:C} – ISBN: {isbn} – Theme: {theme}";
        }
    }
}
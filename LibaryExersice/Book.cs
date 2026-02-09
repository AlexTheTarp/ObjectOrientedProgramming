using System;
using System.Collections.Generic;

namespace LibraryExample
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public bool IsBorrowed { get; set; } = false;

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public void Borrow()
        {
            if (IsBorrowed)
            {
                Console.WriteLine($"{Title} is already borrowed.");
            }
            else
            {
                IsBorrowed = true;
                Console.WriteLine($"{Title} borrowed succesfully.");
            }
        }

        public void Return()
        {
            if (!IsBorrowed)
            {
                Console.WriteLine($"{Title} is not borrowed.");
            }
            else
            {
                IsBorrowed = false;
                Console.WriteLine($"{Title} returned successfully.");
            }
        }

        public override string ToString()
        {
            return $"{Title} by {Author} - {(IsBorrowed ? "Borrowed" : "Available")}";
        }
    }
}

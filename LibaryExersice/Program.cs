using LibraryExample;

class Program
{
    static void Main(string[] args)
    {
        Library library = new Library();

        Book book1 = new Book("The Great Gatsby", "F. Scott Fitzgerald");
        Book book2 = new Book("1984", "George Orwell");
        Book book3 = new Book("To Kill a Mockingbird", "Harper Lee");

        library.AddBook(book1);
        library.AddBook(book2);
        library.AddBook(book3);

        Console.WriteLine("All books in the library:");
        library.ListBooks();

        Console.WriteLine("\nBorrowing '1984':");
        library.BorrowBook("1984");

        Console.WriteLine("\nAll books after borrowing:");
        library.ListBooks();

        Console.WriteLine("\nReturning '1984':");
        library.ReturnBook("1984");

        Console.WriteLine("\nAll books after returning:");
        library.ListBooks();
    }
}
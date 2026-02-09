using LibraryExample;

class Program
{
    static void Main(string[] args)
    {
        Library library = new Library();

        Book book1 = new Book("Spam: A Shadow History of the Internet", "Finn Brunton");
        Book book2 = new Book("Wasting Time on the Internet", "Kenneth Goldsmith");
        Book book3 = new Book("Rise of the Machines: A Cybernetic History", "Thomas Rid");

        library.AddBook(book1);
        library.AddBook(book2);
        library.AddBook(book3);

        Console.WriteLine("All books in the library:");
        library.ListBooks();

        Console.WriteLine("\nBorrowing 'Wasting Time on the Internet':");
        library.BorrowBook("Wasting Time on the Internet");

        Console.WriteLine("\nAll books after borrowing:");
        library.ListBooks();

        Console.WriteLine("\nReturning 'Wasting Time on the Internet':");
        library.ReturnBook("Wasting Time on the Internet");

        Console.WriteLine("\nAll books after returning:");
        library.ListBooks();
    }
}
using LibraryExample;

public class Library
{
    private List<Book> books = new List<Book>();

    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public void BorrowBook(string title)
    {
        Book? book = books.Find(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        if (book != null)
        {
            book.Borrow();
        }
        else
        {
            Console.WriteLine($"Book '{title}' not found.");
        }
    }

    public void ReturnBook(string title)
    {
        Book? book = books.Find(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        if (book != null)
        {
            book.Return();
        }
        else
        {
            Console.WriteLine($"Book '{title}' not found.");
        }
    }

    public void ListBooks()
    {
        Console.WriteLine($"{"Title",-50} {"Author",-30} {"Status",-12}");
        Console.WriteLine(new string('-', 50 + 30 + 12 + 4)); 

        foreach (var book in books)
        {
            string status = book.IsBorrowed ? "Borrowed" : "Available";
            Console.WriteLine($"{book.Title,-50} {book.Author,-30} {status,-12}");
        }
    }
}

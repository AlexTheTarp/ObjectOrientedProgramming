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
        if (books.Count == 0)
        {
            Console.WriteLine("No books in the library.");
        }
        else
        {
            foreach (var book in books)
            {
                Console.WriteLine(book.ToString());
            }
        }
    }
}

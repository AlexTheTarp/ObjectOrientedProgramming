using BookAndAuthorExercise;

public class Author
{
    private string name;
    private string birthday;
    private Book book;

    public Author(string name, string birthday)
    {
        this.name = name;
        this.birthday = birthday;
        book = null;
    }

    public Author(string name, string birthday, Book book)
    {
        this.name = name;
        this.birthday = birthday;
        Book = book;
    }

    public Book Book
    {
        get => book;
        set
        {
            if (value == null || value.Author == name)
            {
                book = value;
            }
            else
            {
                Console.WriteLine(
                    $"Cannot associate book: author mismatch ('{value.Author}' '{name}')");
            }
        }
    }

    public void PrintInformation()
    {
        Console.WriteLine($"Author: {name}    Birthday: {birthday}");
        if (book != null)
        {
            Console.WriteLine("Associated book:");
            book.GetBookDetails(book.ISBN);
        }
        else
        {
            Console.WriteLine("No associated book.");
        }
        Console.WriteLine();
    }
}
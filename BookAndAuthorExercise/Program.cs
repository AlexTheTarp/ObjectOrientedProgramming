using BookAndAuthorExercise;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Book and Author\n");

        var book1 = new Book("The Unknown Soldier", "Väinö Linna", "WSOY", 38.50, "9789510435953");
        var book2 = new Book("Moominpappa at Sea", "Tove Jansson", "Tammi", 22.90, "9789513123456");

        Console.WriteLine("Original theme: " + Book.theme);
        Book.ChangeTheme("Finnish Classic");

        Console.WriteLine("\nAfter theme change:");
        Console.WriteLine($"book1 {book1}");
        Console.WriteLine($"book2 {book2}\n");

        book1.GetBookDetails("9789510435953");
        book1.GetBookDetails("wrong-isbn");

        Console.WriteLine("\nTesting automatic discount:");
        var testBook = new Book("Expensive Book", "Test Author", "Test Pub", 45.00, "9781234567890");
        Console.WriteLine($"Final price: {testBook.Price:C}\n");

        var author1 = new Author("Väinö Linna", "20.12.1920", book1);
        var author2 = new Author("Tove Jansson", "09.08.1914", book2);
        var author3 = new Author("J.K. Rowling", "31.07.1965");
        var wrongBook = new Book("Harry Potter", "J.R.R. Tolkien", "Bloomsbury", 29.90, "9780747532699");
        var author4 = new Author("J.K. Rowling", "31.07.1965", wrongBook);

        Console.WriteLine("Authors");
        author1.PrintInformation();
        author2.PrintInformation();
        author3.PrintInformation();
        author4.PrintInformation();

        Console.WriteLine("Press any key to exit");
        Console.ReadKey();
    }
}
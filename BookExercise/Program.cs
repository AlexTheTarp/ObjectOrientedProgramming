using BookExercise;

namespace BookExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("C# Programming", "Paavo Räisänen", "00123", 29.90);
            Book book2 = new Book("1984", "George Orwell", "00456", 15.50);
            Book book3 = new Book("Harry Potter", "J.K Rowling", "00789", 22.00);

            Console.WriteLine(book1.GetBookInfo());
            Console.WriteLine(book2.GetBookInfo());
            Console.WriteLine(book3.GetBookInfo());
            Console.WriteLine();

            Console.WriteLine("Comparisons:");
            Console.WriteLine(book1.ComparePrice(book2));
            Console.WriteLine(book2.ComparePrice(book3));
            Console.WriteLine(book1.ComparePrice(book3));
        }
    }
}
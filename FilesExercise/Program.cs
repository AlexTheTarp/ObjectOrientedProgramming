using Newtonsoft.Json;

namespace FilesExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileManager fileManager = new FileManager("../../../Data.txt");

            try
            {
                Console.WriteLine(fileManager.ReadWords());
            }
            catch (Exception ex)
            {
                throw new WordListNotFoundException("The word list file was not found.");
            }
            Console.WriteLine();

            List<Movie> movies = JsonConvert.DeserializeObject<List<Movie>>(File.ReadAllText(@"../../../Movie.json"));
            foreach (Movie m in movies)
            {
                Console.WriteLine($"{m.Name}, {m.Year}");
            }
        }
    }
}

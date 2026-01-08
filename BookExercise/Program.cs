namespace BookExercise
{
    class Book
    {
        private string title;
        private string author;
        private string id;
        private double price;

        public Book()
        {
            title = "";
            author = "";
            SetId(id);
            price = 0.0;
        }
    }
}

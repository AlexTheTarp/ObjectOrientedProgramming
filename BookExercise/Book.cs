﻿namespace BookExercise
{
    internal class Book
    {
        private string title;
        private string author;
        private string id;
        private double price;

        public Book()
        {
            this.title = "";
            this.author = "";
            this.id = "00000";
            this.price = 0.0;
        }

        public Book(string title, string author, string id, double price)
        {
            this.title = title;
            this.author = author;
            SetId(id);
            this.price = price;
        }

        public void SetId(string idValue)
        {
            this.id = idValue;
        }

        public string GetBookInfo()
        {
            return $"Title: {title}, Author: {author}, ID: {id}, Price: {price:C}";
        }
        
        public string ComparePrice(Book otherBook)
        {
            if (this.price > otherBook.price)
            {
                return $"{this.title} ({this.price:C}) is more expensive than {otherBook.title} ({otherBook.price:C}).";
            }
            else if (this.price < otherBook.price)
            {
                return $"{otherBook.title} ({otherBook.price:C}) is more expensive than {this.title} ({this.price:C}).";
            }
            else
            {
                return $"{this.title} and {otherBook.title} have the same price ({this.price:C}).";
            }
        }
    }
}
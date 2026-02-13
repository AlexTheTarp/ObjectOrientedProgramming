using System;
using System.Collections.Generic;
using System.Text;

namespace FilesExercise
    {
        internal class Movie
        {
            private string name { get; set; }
            private int year { get; set; }

            public Movie() { }

            public Movie(string name, int year)
            {
                Name = name;
                Year = year;
            }

            public string Name
            {
                get => name;
                set => name = value;
            }
            public int Year
            {
                get => year;
                set => year = value;
            }
        }
    }

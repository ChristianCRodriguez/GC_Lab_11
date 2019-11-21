using System;
using System.Collections.Generic;
using System.IO;

namespace Lab_11
{
    class Movie
    {
        private string category;
        private string title;


        public string Category
        {
            get { return category; }
            set { category = value; }
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public Movie(string category, string title)
        {
            Category = category;
            Title = title;
        }

        public static List<Movie> GetMovieList()
        {
            List<Movie> movieList = new List<Movie>();

            //Enter the path to the txt file here
            StreamReader reader = new StreamReader(@"");

            string data = reader.ReadLine();

            while(data != null)
            {
                string[] movies = data.Split(',');

                try
                {
                    movieList.Add(new Movie(movies[0],movies[1]));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }

                data = reader.ReadLine();
            }

            reader.Close();

            return movieList;
        }

    }
}

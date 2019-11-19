using System;
using System.Collections.Generic;
using System.Text;

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

    }
}

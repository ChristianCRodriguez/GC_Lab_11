using System;
using System.Collections.Generic;
namespace Lab_11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating list of movies
            List<Movie> movieList = new List<Movie>()
            {
                {new Movie("drama", "Joker") },
                {new Movie("horror","IT 2") },
                {new Movie("scifi","Star Wars: A New Hope") },
                {new Movie("animated","Up") },
                {new Movie("horror","The Conjuring") },
                {new Movie("animated","Toy Story") },
                {new Movie("scifi","Fifth Element") },
                {new Movie("scifi","Interstellar") },
                {new Movie("drama","Casablanca") },
                {new Movie("horror","Dr. Slate") }
            };
            List<string> categoryList = new List<string>()
            {
                "animated",
                "drama",
                "horror",
                "scifi"
            };


            
            bool repeat = false;//creating bool to see if user wants to repeat
            
            Console.WriteLine("Welcome to the Movie List!\n\nThere are 10 movies in this list.\nWe have the following categories available to select from:");

            DisplayCategoryList(categoryList);

            do
            {
                Console.Write("What category are you interested in?: ");
                
                //Modified ValidateCategory from Void to Int as before it was not returning the value that was set inside
                int categoryID = ValidateCategory();

                //Added CategoryList to the signature to pull movies with the category selected
                DisplayMovieList(movieList, categoryID, categoryList);

                //checking if user wants to repeat app
                Console.Write("Continue? (y/n): ");
                string continueApp = Console.ReadLine().ToLower();

                ValidateContinueApp(continueApp);

                repeat = IsRepeating(continueApp);

            } while (repeat == true);

            Console.WriteLine("Goodbye!");
        }

        public static void DisplayMovieList(List<Movie> movielist, int category, List<string> categorylist)
        {
            //writing movies to console that are in selected category

            //Sorting movielist Alphabetically by Title 
            movielist.Sort((a, b) => a.Title.CompareTo(b.Title));

            foreach (Movie movie in movielist)
            {
                //passing in categorylist and the category id - 1 to select correct category and display any movie in the list with that category
                if (categorylist[category - 1] == movie.Category)
                {
                    Console.WriteLine(movie.Title);
                }
            }
        }

        public static void DisplayCategoryList(List<string> list)
        {
            int categoryID = 1;
            //displaying category list
            foreach (string category in list)
            {
                Console.WriteLine($"{categoryID}. {category}");
                categoryID++;
            }
        }

        public static int ValidateCategory()
        {
            string category = Console.ReadLine();
            //validating user input
            while (category != "1" && category != "2" && category != "3" && category != "4")
            {
                Console.Write("\nThat category is not available, please select using the number next to the category: ");
                category = Console.ReadLine();
            }
            return int.Parse(category);
        }

        public static void ValidateContinueApp(string input)
        {
            //validating user input
            while (input != "y" && input != "n")
            {
                Console.Write("\nThat input is invalid, please enter y or n: ");
                input = Console.ReadLine().ToLower();
            }
        }

        public static bool IsRepeating(string input)
        {
            //setting repeat to true if yes, false if no
            if (input == "y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

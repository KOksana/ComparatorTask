using System;
using System.Collections.Generic;

namespace ComparatorTask
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> movieList = new List<Movie>();
            movieList.Add(new Movie("First movie", 2000, 5.5));
            movieList.Add(new Movie("The best movie", 2011, 8.7));
            movieList.Add(new Movie("The best movie", 2008, 8.0));
            movieList.Add(new Movie("Second movie", 2001, 4.8));
            movieList.Add(new Movie("New movie", 2015, 5.5));
            movieList.Add(new Movie("Movie 1", 2011, 6.5));
            movieList.Add(new Movie("Movie 2", 2012, 7.5));

           
            movieList.Sort();
            Console.WriteLine("--- Movies sorted by score (default) ---");
            foreach (var movie in movieList)
            {
                Console.WriteLine(movie);
            }
            Console.WriteLine();

            movieList.Sort(new MovieTitleComparator());
            Console.WriteLine("--- Movies sorted by title ---");
            foreach (var movie in movieList)
            {
                Console.WriteLine(movie);
            }
            Console.WriteLine();

            movieList.Sort(new MovieYearComparator());
            Console.WriteLine("--- Movies sorted by year ---");
            foreach (var movie in movieList)
            {
                Console.WriteLine(movie);
            }

            Console.Read();
        }
    }
}

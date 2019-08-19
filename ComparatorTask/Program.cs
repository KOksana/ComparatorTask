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
            movieList.Add(new Movie("The best movie2", 2011, 8.7));
            movieList.Add(new Movie("The best movie", 2008, 8.0));
            movieList.Add(new Movie("Second movie", 2001, 4.8));
            movieList.Add(new Movie("New movie", 2015, 5.5));
            movieList.Add(new Movie("Movie 1", 2011, 6.5));
            movieList.Add(new Movie("Movie 2", 2012, 7.5));

            SortedSet<Movie> movieSet = new SortedSet<Movie>(movieList);

            Console.WriteLine("--- Movies from SortedSet sorted by score (default) ---");
            foreach (var movie in movieSet)
            {
                Console.WriteLine(movie);
            }

            movieList.Sort(new MovieScoreComparator());
            Console.WriteLine("\n--- Movies sorted by score ---");
            foreach (var movie in movieList)
            {
                Console.WriteLine(movie);
            }

            movieList.Sort(new MovieTitleComparator());
            Console.WriteLine("\n--- Movies sorted by title ---");
            foreach (var movie in movieList)
            {
                Console.WriteLine(movie);
            }

            movieList.Sort(new MovieYearComparator());
            Console.WriteLine("\n--- Movies sorted by year ---");
            foreach (var movie in movieList)
            {
                Console.WriteLine(movie);
            }

            Console.WriteLine("\n****** Remove movies result ******");

            Movie[] movieArray = new Movie[movieSet.Count];
            movieSet.CopyTo(movieArray);
            
            foreach(var elem in movieArray)
            {
                if (elem.Score < 8)
                    movieSet.Remove(elem);
            }

            Console.WriteLine("\n--- Remove movies from movieSet with the score less than 8, using CopyTo ---");
            foreach (var elem in movieSet)
            {
                Console.WriteLine(elem);
            }

            int count = movieList.Count;
            int deleted = 0;
            for (int i = 0; i < count; i++)
            {
                if (movieList[i - deleted].Score < 6)
                {
                    movieList.RemoveAt(i - deleted);
                    deleted++;
                }
            }

            Console.WriteLine("\n--- Remove movies from movieList with the score less than 6, using FOR loop ---");

            foreach (var elem in movieList)
            {
                Console.WriteLine(elem);
            }

            foreach (var elem in movieList.ToArray())
            {
                if (elem.Score < 8)
                    movieList.Remove(elem);
            }

            Console.WriteLine("\n--- Remove movies from movieList with the score less than 8, using ToArray() ---");

            foreach (var elem in movieList)
            {
                Console.WriteLine(elem);
            }

            movieList.RemoveAll(movie => movie.Year < 2010);
            Console.WriteLine("\n--- Remove movies from movieList with the year less than 2010 using RemoveAll and lambda expression ---");

            foreach (var elem in movieList)
            {
                Console.WriteLine(elem);
            }

            IEnumerator<Movie> iter = movieSet.GetEnumerator();

            while (iter.MoveNext())
            {
                movieSet.Remove(iter.Current);
                iter = movieSet.GetEnumerator();
            }

            Console.WriteLine("\n--- Remove all movies from movieSet ---");
            foreach (var elem in movieSet)
            {
                Console.WriteLine(elem);
            }

            Console.Read();
        }
    }
}

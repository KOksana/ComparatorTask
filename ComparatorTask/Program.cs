using System;
using System.Collections.Generic;

namespace ComparatorTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var movieList = new List<Movie>
            {
                new Movie("Movie 12", 2012, 7.5),
                new Movie("First movie", 2000, 5.5),
                new Movie("The best movie2", 2011, 8.7),
                new Movie("The best movie", 2008, 8.0),
                new Movie("Second movie", 2001, 4.8),
                new Movie("New movie", 2015, 5.5),
                new Movie("Movie 1", 2011, 6.5),
                new Movie("Movie 2", 2012, 7.5)
            };

            var movieSet = new SortedSet<Movie>(movieList);

            Console.WriteLine("--- Movies from SortedSet sorted by score (default) ---");
            foreach (var movie in movieSet)
            {
                Console.WriteLine(movie);
            }
            Console.WriteLine($"Count: {movieSet.Count}");

            movieList.Sort(new MovieScoreComparator());
            Console.WriteLine("\n--- Movies sorted by score ---");
            foreach (var movie in movieList)
            {
                Console.WriteLine(movie);
            }
            Console.WriteLine($"Count: {movieList.Count}");

            movieList.Sort(new MovieTitleComparator());
            Console.WriteLine("\n--- Movies sorted by title ---");
            foreach (var movie in movieList)
            {
                Console.WriteLine(movie);
            }
            Console.WriteLine($"Count: {movieList.Count}");

            movieList.Sort(new MovieYearComparator());
            Console.WriteLine("\n--- Movies sorted by year ---");
            foreach (var movie in movieList)
            {
                Console.WriteLine(movie);
            }
            Console.WriteLine($"Count: {movieList.Count}");

            Console.WriteLine("\n****** Remove movies result ******");

            var movieArray = new Movie[movieSet.Count];
            movieSet.CopyTo(movieArray);
            Console.WriteLine($"MovieArray Count: {movieArray.Length}");
            Console.WriteLine($"MovieSet Count: {movieSet.Count}");
            
            foreach(var element in movieArray)
            {
                if (!(element.Score < 8)) continue;
                Console.WriteLine($"Removing element: {element}!");
                movieSet.Remove(element);
            }

            Console.WriteLine("\n--- Remove movies from movieSet with the score less than 8, using CopyTo ---");
            foreach (var element in movieSet)
            {
                Console.WriteLine(element);
            }

            var count = movieList.Count;
            var deleted = 0;
            for (var i = 0; i < count; i++)
            {
                if (!(movieList[i - deleted].Score < 6)) continue;
                movieList.RemoveAt(i - deleted);
                deleted++;
            }

            Console.WriteLine("\n--- Remove movies from movieList with the score less than 6, using FOR loop ---");

            foreach (var elem in movieList)
            {
                Console.WriteLine(elem);
            }
            Console.WriteLine($"MovieList count: {movieList}");

            foreach (var element in movieList.ToArray())
            {
                if (!(element.Score < 8)) continue;
                Console.WriteLine($"Removing element: {element}!");
                movieList.Remove(element);
            }
            Console.WriteLine($"MovieList count: {movieList.Count}");

            Console.WriteLine("\n--- Remove movies from movieList with the score less than 8, using ToArray() ---");

            foreach (var elem in movieList)
            {
                Console.WriteLine(elem);
            }
            Console.WriteLine($"MovieList count: {movieList.Count}");

            Console.WriteLine($"\n---MovieList count before RemoveAll: {movieList.Count}");
            Console.WriteLine("\n--- Remove movies from movieList with the year less than 2010 using RemoveAll and lambda expression ---");
            movieList.RemoveAll(movie => movie.Year < 2010);
            Console.WriteLine($"MovieList count after RemoveAll: {movieList.Count}");

            foreach (var elem in movieList)
            {
                Console.WriteLine(elem);
            }
            Console.WriteLine($"MovieList count: {movieList.Count}");

            IEnumerator<Movie> enumerator = movieSet.GetEnumerator();
            while (enumerator.MoveNext())
            {
                movieSet.Remove(enumerator.Current);
                enumerator = movieSet.GetEnumerator();
            }
            enumerator.Dispose();
            Console.WriteLine($"MovieList count: {movieSet.Count}");

            Console.WriteLine("\n--- that's all that's left - the end ---");
            foreach (var elem in movieSet)
            {
                Console.WriteLine(elem);
            }

            Console.Read();
        }
    }
}

using System.Collections.Generic;


namespace ComparatorTask
{
    class MovieYearComparator : IComparer<Movie>
    {
        public int Compare(Movie x, Movie y)
        {
            if (x == y)
                return 0;
            if (x == null)
                return -1;
            if (y == null)
                return 1;
            return x.Year < y.Year ? -1 : (x.Year == y.Year ? 0 : 1);
        }
    }
}
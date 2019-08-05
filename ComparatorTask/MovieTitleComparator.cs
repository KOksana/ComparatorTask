using System.Collections.Generic;

namespace ComparatorTask
{
    class MovieTitleComparator : IComparer<Movie>
    {
        public int Compare(Movie x, Movie y)
        {
            if (x == y)
                return 0;
            if (x == null)
                return -1;
            if (y == null)
                return 1;
            return string.CompareOrdinal(x.Title, y.Title);
        }
    }
}

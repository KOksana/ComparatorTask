using System;
using System.Collections.Generic;

namespace ComparatorTask
{
    class MovieTitleComparator : IComparer<Movie>
    {
        public int Compare(Movie x, Movie y)
        {
            return x == y ? 0 :
                x == null ? -1 : 
                y == null ? 1 :
                string.Compare(x.Title, y.Title, StringComparison.InvariantCultureIgnoreCase);
        }
    }
}

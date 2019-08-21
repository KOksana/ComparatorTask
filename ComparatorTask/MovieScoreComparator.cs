using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparatorTask
{
    class MovieScoreComparator : IComparer<Movie>
    {
        public int Compare(Movie x, Movie y)
        {
            return x == y ? 0 :
                x == null ? -1 :
                y == null ? 1 :
                x.Score < y.Score ? -1 :
                x.Score == y.Score ? 0 : 1;
        }
    }
}

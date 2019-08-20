using System.Collections.Generic;

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
                x.Score.Equals(y.Score) ? 0 : 1;
        }
    }
}

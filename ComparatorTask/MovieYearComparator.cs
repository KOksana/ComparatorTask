﻿using System.Collections.Generic;


namespace ComparatorTask
{
    class MovieYearComparator : IComparer<Movie>
    {
        public int Compare(Movie x, Movie y)
        {
            return x == y ? 0 :
                x == null ? -1 :
                y == null ? 1 :
                x.Year < y.Year ? -1 :
                x.Year == y.Year ? 0 : 1;
        }
    }
}
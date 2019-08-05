using System;

namespace ComparatorTask
{
    public class Movie : IComparable
    {
        public string Title { get; }
        public int Year { get; }
        public double Score { get; }

        public Movie(string title, int year, double score)
        {
            Title = title;
            Year = year;
            Score = score;
        }

        public override string ToString()
        {
            return "\""+ Title + "\", " + Year +  ", score: " + Score ;
        }

        public int CompareTo(object obj)
        {
            Movie movie = (Movie) obj;
            return (Score < movie.Score) ? -1 : (Score > movie.Score ? 1 : 0);
        }
    }
}

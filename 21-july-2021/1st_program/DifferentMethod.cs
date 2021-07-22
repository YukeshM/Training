using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13_1
{
    public class Methods<T>
    {
        public void Add(MoviesList moviesList)
        {
            //Console.WriteLine(moviesList);
        }
        public void Multiply ()
        {

        }
        public void Sort()
        {

        }

    }
    public class MoviesList
    {
        public string Rating { get; set; }
        public string MovieName { get; set; }
        public MoviesList(string movieRating, string kollywoodMovieName)
        {
            this.Rating = movieRating;
            this.MovieName = kollywoodMovieName;
        }
    }
}

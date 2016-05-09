using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var sr = new ServiceReference1.CinemaMoviesSoapClient())
            {
                var movies = sr.GetAvailableMovies();

                foreach (var movie in movies)
                {
                    Console.WriteLine(movie.Title);
                }

                Console.ReadKey();
            }

        }
    }
}

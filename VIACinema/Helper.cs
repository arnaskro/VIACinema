using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VIACinema.Models;

namespace VIACinema
{
    public static class Helper
    {
        public static TimeSpan ToTimeSpan(this string timeString)
        {
            var dt = DateTime.Parse(timeString);
            return dt.TimeOfDay;
        }


        public static List<Movie> GetAvailableMovies()
        {
            using (CinemaContext db = new CinemaContext())
            {
                // Query All Movies
                var query = from q
                            in db.Movies
                            select q;

                // Convert Movie Query to a List
                var AllMovies = query.ToList();

                // Create an empty Movie list instance to store available movies
                List<Movie> AvailableMovies = new List<Movie>();

                // For each Movie in All Movies
                foreach (Movie movie in AllMovies)
                    if (movie.MovieSessions.Count > 0)
                        foreach (MovieSession movieSession in movie.MovieSessions)
                            if (movieSession.SessionDate >= DateTime.Today)
                            {
                                // Add movie to the list
                                AvailableMovies.Add(movie);

                                // Stop checking movie sessions because we just 
                                // added the movie and don't want any duplicates
                                // So we break out of the loop...
                                break;
                            }
                                

                return AvailableMovies;
            }
        }
    }
}
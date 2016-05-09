using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using VIACinema.Models;
using VIACinema.Models.ServiceModels;

namespace VIACinema.Services
{
    /// <summary>
    /// Summary description for CinemaMovies
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CinemaMovies : System.Web.Services.WebService
    {

        [WebMethod]
        public List<MovieS> GetAvailableMovies()
        {
            // Get all availables movies
            var availableMovies = Helper.GetAvailableMovies();

            // Initialize a new list of Service model Movie to store converted models
            var availableMoviesToReturn = new List<MovieS>();

            // Covert each model to our new model
            foreach(var movie in availableMovies)
            {
                var convertedMovie = new MovieS();
                convertedMovie.Description = movie.Description;
                convertedMovie.Id = movie.Id;
                convertedMovie.ImageUrl = movie.ImageUrl;
                convertedMovie.ReleaseYear = movie.ReleaseYear;
                convertedMovie.Title = movie.Title;

                // Add it the list
                availableMoviesToReturn.Add(convertedMovie);
            }

            return availableMoviesToReturn;
        }

    }
}

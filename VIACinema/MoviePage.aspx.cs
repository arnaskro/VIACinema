using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VIACinema.Models;

namespace VIACinema
{
    public partial class MoviePage : System.Web.UI.Page
    {
        private Movie movie = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            var MovieID = Request.QueryString["id"];

            if (MovieID == null)
            {
                (Master as Main).Show_Alert("ID is null!", "error");
            } else
            {
                try {
                    movie = (new CinemaContext()).Movies.Find(int.Parse(MovieID));

                    if (movie != null)  InitializeMoviePage();

                } catch (Exception ex) {
                    (Master as Main).Show_Alert("No Movie found!\n\n" + ex.Message, "error");
                }
            }
        }

        private void InitializeMoviePage()
        {
            MovieTitle.InnerText = movie.Title;
            MovieYear.InnerText = movie.ReleaseYear;
            MovieImage.ImageUrl = movie.ImageUrl;
            MovieDescription.InnerText = movie.Description;
        }
    }
}
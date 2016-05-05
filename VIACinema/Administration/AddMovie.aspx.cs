using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VIACinema.Models;

namespace VIACinema.Administration
{
    public partial class AddMovie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ( (Session["user"] == null) || (((User)Session["user"]).Admin == false) )
            {
                Server.Transfer("/Home.aspx", true);
            }
        }

        protected void SubmitAddMovie_Click(object sender, EventArgs e)
        {
            using (var db = new CinemaContext())
            {
                var title = InputTitle.Text;
                var description = InputDescription.Text;
                var releaseYear = InputReleaseYear.Text;
                var imageUrl = InputImageURL.Text;

                var movie = new Movie();
                movie.Description = description;
                movie.Title = title;
                movie.ImageUrl = imageUrl;
                movie.ReleaseYear = releaseYear;

                try
                {
                    db.Movies.Add(movie);
                    db.SaveChanges();

                    (Master as Main).Show_Alert("Movie "+ InputTitle.Text + " added successfully!", "success");
                } catch (Exception ex)
                {
                    (Master as Main).Show_Alert(ex.Message, "error");
                }

            }
        }
    }
}
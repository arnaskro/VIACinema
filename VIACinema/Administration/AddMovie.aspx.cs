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

        }

        protected void SubmitAddMovie_Click(object sender, EventArgs e)
        {
            using (var db = new CinemaContext())
            {
                var title = InputTitle.Text;
                var description = InputDescription.Text;
                var releaseDate = InputReleaseDate.Text;

                var movie = new Movie();
                movie.Description = description;
                movie.Title = title;
                movie.ReleaseDate = Convert.ToDateTime(releaseDate);

                try
                {
                    db.Movies.Add(movie);
                    db.SaveChanges();


                    Master.FindControl("AlertError").Visible = false;
                    Master.FindControl("AlertSuccess").Visible = true;
                    ((Label)Master.FindControl("AlertSuccessLabel")).Text = "Movie added successfully!";
                } catch (Exception ex)
                {
                    Master.FindControl("AlertError").Visible = true;
                    Master.FindControl("AlertSuccess").Visible = false;
                    ((Label)Master.FindControl("AlertErrorLabel")).Text = ex.Message;
                }

            }
        }
    }
}
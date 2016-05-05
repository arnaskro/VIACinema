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
        private string MovieID = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            MovieID = Request.QueryString["id"];

            if (MovieID == null)
            {
                MovieIDLabel.Text = "No Movie found!";
            } else
            {
                MovieIDLabel.Text = "Movie ID is: " + MovieID;
            }
            
        }
    }
}
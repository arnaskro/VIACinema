using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VIACinema.Models;

namespace VIACinema
{
    public partial class MovieSessionPage : System.Web.UI.Page
    {
        private string MovieSessionID = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            MovieSessionID = Request.QueryString["id"];

            if (MovieSessionID == null)
            {
                MovieID.Text = "No Movie Session found!";
            } else
            {
                MovieID.Text = "Movie ID is: " + MovieSessionID;
            }
            
        }
    }
}
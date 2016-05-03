using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VIACinema.Models;

namespace VIACinema
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (CinemaContext db = new CinemaContext() )
            {
                var query = from q 
                            in db.Movies
                            select q;

                GridMovies.DataSource = query.ToList();
                GridMovies.DataBind();

            }
        }
    }
}
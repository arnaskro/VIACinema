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
            var availableMovies = Helper.GetAvailableMovies();

            if (availableMovies.Count == 0)
            {
                (Master as Main).Show_Alert("There are no available movies!", "info");
            }
            else 
            {
                ListViewMS.DataSource = availableMovies;
                ListViewMS.DataBind();
            }
        }
        
    }
}
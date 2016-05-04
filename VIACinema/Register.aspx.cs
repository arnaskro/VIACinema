using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VIACinema.Models;

namespace VIACinema
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using ( var db = new CinemaContext() )
            {
                User u = new Models.User();
                u.Name = name.Text;
                u.Address = address.Text;
                u.Email = email.Text;
                u.Password = password.Text;
                db.Users.Add(u);
                db.SaveChanges();
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VIACinema.Models;


namespace VIACinema
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["login"] = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (var db = new CinemaContext())
            {
                var check = false;
                var query = from q
                            in db.Users
                            select q;

                User[] users = query.ToArray<User>();

                for(int i=0; i < users.Length; i++)
                {
                    if(users[i].Email == email.Text && users[i].Password == password.Text)
                    {
                        Session["user"] = users[i];
                        check = true;
                        break;
                    }
                }

                if (check) {
                    Session["login"] = true;
                    Label3.Text = "Successful login " + Session["login"];

                }
                else
                    Label3.Text = "Incorrect email or password " + Session["login"];
            }
        }
    }
}
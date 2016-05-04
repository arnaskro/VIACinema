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
            if (Session["user"] != null)
            {
                Server.Transfer("/Home.aspx", true);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (var db = new CinemaContext())
            {
                var query = from q
                            in db.Users
                            select q;

                User[] users = query.ToArray<User>();

                for(int i=0; i < users.Length; i++)
                {
                    if(users[i].Email == email.Text && users[i].Password == password.Text)
                    {
                        Session["user"] = users[i];
                        break;
                    }
                }

                if (Session["user"]!=null)
                {
                    Server.Transfer("/Home.aspx", true);
                }
                else {
                    (Master as Main).Show_Alert("Incorrect email or password!", "error");
                }

            }
        }
    }
}
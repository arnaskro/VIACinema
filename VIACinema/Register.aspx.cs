﻿using System;
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
            if (Session["user"] != null)
            {
                Server.Transfer("/Home.aspx", true);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (var db = new CinemaContext())
            {
                try
                {
                    User u = new Models.User();
                    CreditCard cc = new Models.CreditCard();
                    u.Name = name.Text;
                    u.Address = address.Text;
                    u.Email = email.Text;
                    u.Password = password.Text;

                    db.Users.Add(u);
                    db.SaveChanges();

                    Server.Transfer("/Login.aspx", true);
                }
                catch (Exception ex)
                {
                    (Master as Main).Show_Alert("Incorrect email or password!", "error");
                }

            }
        }

    }
}
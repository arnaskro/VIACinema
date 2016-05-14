﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VIACinema.Models;

namespace VIACinema
{
    public partial class ManageUsers : System.Web.UI.Page
    {
        private List<User> users;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Session["user"] != null)
                {
                    users = new CinemaContext().Users.ToList();
                    loadUsers();
                }
                else
                {
                    Server.Transfer("/Home.aspx", true);
                }
            }
        }

        private void loadUsers()
        {
            if (users.Count > 0)
            {
                ListUsers.DataSource = users;
                ListUsers.DataBind();

            }
            else
            {
                UserPanelBody.Visible = true;
                ListUsers.Visible = false;
            }
        }

        protected void ListUsers_ItemCommand(object source, DataListCommandEventArgs e)
        {
            DataListItem item = e.Item;

            int userId = int.Parse(((Label)item.FindControl("userId")).Text);
            using (var db = new CinemaContext())
            {
                try
                {
                    db.Users.Remove(db.Users.Find(userId));
                    db.SaveChanges();
                    (Master as Main).Show_Alert("User removed!", "info");
                    Response.Redirect("/Administration/ManageUsers.aspx");
                }
                catch (Exception ex)
                {
                    (Master as Main).Show_Alert("Error!" + ex.Message, "error");
                }
            }
        }

        protected void ListCreditCards_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }


}
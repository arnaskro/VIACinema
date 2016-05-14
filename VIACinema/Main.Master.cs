using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VIACinema.Models;

namespace VIACinema
{
    public partial class Main : System.Web.UI.MasterPage
    {
        private User user;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                LoggedOut.Visible = false;
                loggedIn.Visible = true;

                user = (User) Session["user"];

                UserLink.HRef = "~/UserPage.aspx";
                UserName.InnerText = user.Name;

                if (user.Admin)
                    AdministrationControl.Visible = true;
            }
        }

        public void Show_Alert(string text, string type)
        {

            AlertError.Visible = false;
            AlertSuccess.Visible = false;
            AlertWarning.Visible = false;
            AlertInfo.Visible = false;

            switch(type.ToLower())
            {
                case "error":
                case "danger":
                    AlertError.Visible = true;
                    AlertErrorLabel.Text = text;
                    break;
                case "success":
                    AlertSuccess.Visible = true;
                    AlertSuccessLabel.Text = text;
                    break;
                case "warning":
                    AlertWarning.Visible = true;
                    AlertWarningLabel.Text = text;
                    break;
                default:
                    AlertInfo.Visible = true;
                    AlertInfoLabel.Text = text;
                    break;
            }
            
        }
    }
}
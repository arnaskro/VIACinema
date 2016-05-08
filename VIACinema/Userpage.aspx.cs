using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VIACinema.Models;

namespace VIACinema
{
    public partial class UserPage : System.Web.UI.Page
    {
        private User user;
        private List<CreditCard> creditCards;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Session["user"] != null)
                {
                    user = (new CinemaContext()).Users.Find(((User)Session["user"]).Id);
                    creditCards = user.CreditCards.ToList();
                
                    initializeFields();
                } else
                {
                    Server.Transfer("/Home.aspx", true);
                }
            }
            
        }
        
        private void loadCreditCards()
        { 
            // Credit Card fields
            if (creditCards.Count > 0)
            {
                ListCreditCards.DataSource = creditCards;
                ListCreditCards.DataBind();

            }
            else
            {
                CreditCardPanelBody.Visible = true;
                ListCreditCards.Visible = false;
            }
        }

        private void initializeFields()
        {
            // User info data fields
            Email.Text = user.Email;
            Name.Text = user.Name;
            Address.Text = user.Address;

            loadCreditCards();

        }
        

        protected void SubmitChanges_Click(object sender, EventArgs e)
        {
            using (var db = new CinemaContext())
            {
                try
                {
                    user = db.Users.Find(((User)Session["user"]).Id);

                    user.Email = Email.Text;
                    user.Name = Name.Text;
                    user.Address = Address.Text;
                    
                    db.SaveChanges();

                    Session["user"] = user;
                    ((Label)(Master as Main).FindControl("UserName")).Text = user.Name;
                    (Master as Main).Show_Alert("User info updated!", "info");
                }
                catch (Exception ex)
                {
                    (Master as Main).Show_Alert("Error!" + ex.Message, "error");
                }
            }
        }

        protected void ListCreditCards_ItemCommand(object source, DataListCommandEventArgs e)
        {
            DataListItem item = e.Item;

            int cardID = int.Parse(((Label)item.FindControl("ccCardId")).Text);
            
            using (var db = new CinemaContext())
            {
                try
                {
                    db.CreditCards.Remove(db.CreditCards.Find(cardID));
                    db.SaveChanges();
                    (Master as Main).Show_Alert("Credit Card removed!", "info");
                    Response.Redirect("/UserPage.aspx");
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
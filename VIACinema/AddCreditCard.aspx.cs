using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VIACinema.Models;

namespace VIACinema
{
    public partial class AddCreditCard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (var db = new CinemaContext())
            {
                try
                {
                    // Create new credit card
                    CreditCard newCreditCard = new CreditCard();
                    newCreditCard.Code = CreditCardNumber.Text;
                    newCreditCard.ExpirationDate = ExpirationDate.Text;
                    newCreditCard.UserId = ((User)Session["user"]).Id;

                    // Check if credit card doesn't exist in the database
                    if (db.CreditCards.Where(cc => cc.Code == newCreditCard.Code).Count() == 0)
                    {
                        db.CreditCards.Add(newCreditCard);
                        db.SaveChanges();

                        (Master as Main).Show_Alert("New Credit Card added!", "success");
                        Response.Redirect("/UserPage.aspx");
                    }
                    else
                    {
                        throw new Exception("Credit Card is already in the database!");
                    }

                }
                catch (Exception ex)
                {
                    (Master as Main).Show_Alert(ex.Message, "error");
                }
            }
        }
    }
}
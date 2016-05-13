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
                    using (var service = new CreditCardValidator.CreditCardValidatorSoapClient("CreditCardValidatorSoap"))
                    {
                        int result = service.ValidCard(newCreditCard.Code, newCreditCard.ExpirationDate);
                        switch (result)
                        {
                            case 0:
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
                                break;
                            case 1001:
                                (Master as Main).Show_Alert("No credit card number", "error");
                                break;
                            case 1002:
                                (Master as Main).Show_Alert("No expiration date", "error");
                                break;
                            case 1003:
                                (Master as Main).Show_Alert("Invalid card type", "error");
                                break;
                            case 1004:
                                (Master as Main).Show_Alert("Invalid card length", "error");
                                break;
                            case 1005:
                                (Master as Main).Show_Alert("Bad mod 10 check", "error");
                                break;
                            case 1006:
                                (Master as Main).Show_Alert("Bad expiration date", "error");
                                break;
                            default:
                                (Master as Main).Show_Alert("Error", "error");
                                break;
                        }
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
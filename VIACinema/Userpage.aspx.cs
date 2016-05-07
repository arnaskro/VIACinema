using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VIACinema.Models;

namespace VIACinema
{
    public partial class Userpage : System.Web.UI.Page
    {
        private User user;
        private CreditCard cc = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            using (var db = new CinemaContext())
            {
                user = (User)Session["user"];

                name.Text = user.Name;
                password.Text = user.Password;

                var query = from q
                          in db.CreditCards
                            select q;

                CreditCard[] creditCards = query.ToArray<CreditCard>();
                for (int i = 0; i < creditCards.Length; i++)
                {
                    if (creditCards[i].UserId == user.Id)
                    {
                        cc = creditCards[i];
                        break;
                    }
                }
                if (cc != null)
                {
                    number.Text = cc.Code;
                    expirationdate.Text = "" + cc.ExpirationDate;
                }

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (var db = new CinemaContext())
            {
                if (name.Text != null)
                    db.Users.Find(user.Id).Name = name.Text;
                if (password.Text != null)
                    db.Users.Find(user.Id).Password = password.Text;
                if (cc != null)
                {
                    if (number.Text != null)
                        db.CreditCards.Find(cc.Id).Code = number.Text;
                    if (expirationdate.Text != null)
                        db.CreditCards.Find(cc.Id).ExpirationDate = expirationdate.Text;
                }
                else
                {
                    try
                    {
                        cc = new Models.CreditCard();
                        cc.Code = number.Text;
                        cc.ExpirationDate = expirationdate.Text;
                        cc.User = user;

                        db.CreditCards.Add(cc);
                        db.SaveChanges();
                        
                        (Master as Main).Show_Alert("New Credit Card added successfully!", "success");
                    }
                    catch (Exception ex)
                    {
                        (Master as Main).Show_Alert(ex.Message, "error");
                    }
                }
            }
        }
    }
}
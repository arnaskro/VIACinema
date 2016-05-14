using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VIACinema.Models;

namespace VIACinema
{
    public partial class Payment : System.Web.UI.Page
    {
        private MovieSession movieSession;
        private List<int> SelectedSeatIndexes;

        protected void Page_Load(object sender, EventArgs e)
        {
                try
                {
                    movieSession = (new CinemaContext()).MovieSessions.Find(Session["SelectedMovieSessionID"]);
                    SelectedSeatIndexes = ((List<int>)Session["SelectedSeatIndexes"]);

                    if (movieSession == null || SelectedSeatIndexes == null)
                        throw new Exception();

                }
                catch (Exception ex)
                {
                    (Master as Main).Show_Alert("Error while loading data!", "error");
                }

                InfoMovie.InnerHtml = movieSession.Movie.Title + " <small>(" + movieSession.Movie.ReleaseYear + ")</small>";
                InfoStage.InnerText = movieSession.Stage.Title;
                InfoDate.InnerText = movieSession.SessionDate.ToString();
                InfoPrice.InnerText = movieSession.Price.ToString();
                InfoSeats.InnerText = SelectedSeatIndexes.Count().ToString();
                InfoTotalPrice.InnerHtml = "<strong>" + (movieSession.Price * SelectedSeatIndexes.Count()).ToString() + " DKK</strong>";
            InitiliazeCreditCardInformation();
           
        }

        private void InitiliazeCreditCardInformation()
        {
            if (Session["user"] != null)
            {
                var creditCards = (new CinemaContext()).Users.Find(((User)Session["user"]).Id).CreditCards;
                var creditCardsList = new List<CreditCard>();

                var dummyCard = new CreditCard();
                dummyCard.Code = "-- Select a Credit Card --";
                dummyCard.Id = 0;

                creditCardsList.Add(dummyCard);

                foreach (var creditCard in creditCards)
                    creditCardsList.Add(creditCard);

                if (creditCards.Count > 0)
                {
                    CreditCardSelect.Visible = true;
                    CreditCardList.DataTextField = "Code";
                    CreditCardList.DataValueField = "Id";
                    CreditCardList.DataSource = creditCardsList;

                    if (!Page.IsPostBack)
                    {
                        CreditCardList.DataBind();
                    }
                }

                UserEmail.Visible = false;
            }
        }

        protected void ConfirmPayment_Click(object sender, EventArgs e)
        {
            using (var db = new CinemaContext())
            {

                try
                {
                    string ccnumber = CCnumber.Text;
                    string ccexpdate = CCexpDate.Text;
                    string useremail = UserEmail.Text;

                    // first we get/check info from credit card fields
                    if (useremail.Length > 0 && ccnumber.Length > 0 && ccexpdate.Length > 0)
                    {
                        // Register the reservation
                        // Create new user
                        User newUser = new User();
                        newUser.Email = useremail;
                        newUser.Password = "123";
                        newUser.Admin = false;
                        newUser.Address = "Not provided";
                        newUser.Name = "Not provided";

                        if (db.Users.Where(u => u.Email == newUser.Email).Count() == 0)
                        {
                            try
                            {
                                db.Users.Add(newUser);
                                db.SaveChanges();
                            } catch(Exception eh)
                            {
                                throw new Exception("User error when adding to database!");
                            }
                        }
                        else
                        {
                            throw new Exception("User with that emails already exists!");
                        }

                        // Get User
                        newUser = db.Users.First(u => u.Email == useremail);

                        // Create new credit card
                        CreditCard newCreditCard = new CreditCard();
                        newCreditCard.Code = ccnumber;
                        newCreditCard.ExpirationDate = ccexpdate;
                        newCreditCard.UserId = db.Users.First(u => u.Email == useremail).Id;

                        using (var service = new CreditCardValidator.CreditCardValidatorSoapClient("CreditCardValidatorSoap"))
                        {
                            int result = service.ValidCard(newCreditCard.Code, newCreditCard.ExpirationDate);

                            if (result == 0)
                            {
                                // Create reservations
                                // foreach seat
                                foreach (int selectedSeatIndex in SelectedSeatIndexes)
                                {
                                    var reservation = new Reservation();
                                    reservation.MovieSessionId = movieSession.Id;
                                    reservation.PricePayed = movieSession.Price * SelectedSeatIndexes.Count();
                                    reservation.UserId = newUser.Id;
                                    reservation.SeatId = movieSession.Stage.Seats.First(s => s.Number == selectedSeatIndex).Id;

                                    db.Reservations.Add(reservation);
                                    db.SaveChanges();
                                }
                            }
                            else
                            {
                                db.Users.Remove(newUser);
                                db.SaveChanges();
                                throw new Exception("Credit card is not valid!");
                            }
                        }
                        
                    }
                    else // if there are no info then we select a card from the list or return an error
                    {
                        if (Session["user"] != null) // if the user is online
                        {
                            // check if a card is selected from the list
                            if (CreditCardList.SelectedValue != "0" )
                            {
                                int userId = ((User)Session["user"]).Id;
                                // Create reservations
                                // foreach seat
                                foreach (int selectedSeatIndex in SelectedSeatIndexes)
                                {
                                    var reservation = new Reservation();
                                    reservation.MovieSessionId = movieSession.Id;
                                    reservation.PricePayed = movieSession.Price * SelectedSeatIndexes.Count();
                                    reservation.UserId = userId;
                                    reservation.SeatId = movieSession.Stage.Seats.First(s => s.Number == selectedSeatIndex).Id;

                                    db.Reservations.Add(reservation);
                                    db.SaveChanges();
                                }
                            }
                            else
                            {
                                throw new Exception("No credit card selected!");
                            }
                        }
                        else
                        {
                            throw new Exception("No credit card info provided!");
                        }
                    }

                    (Master as Main).Show_Alert("Reservations added successfully!", "success");
                    ConfirmPayment.Visible = false;
                    PanelDetails.Visible = false;

                }
                catch (Exception ex)
                {
                    (Master as Main).Show_Alert("Error: " + ex.Message, "error");
                }
            }
        }
    }
}
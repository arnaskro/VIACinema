using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VIACinema.Models;

namespace VIACinema
{
    public partial class SeatReservation : System.Web.UI.Page
    {
        private MovieSession movieSession;
        private List<int> SelectedSeatIndexes;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (ViewState["SelectedSeatIndexes"] != null)
                SelectedSeatIndexes = (List<int>)ViewState["SelectedSeatIndexes"];
            else
                SelectedSeatIndexes = new List<int>();

            if (!Page.IsPostBack)
            {
                var MovieSessionID = Request.QueryString["id"];

                if (MovieSessionID == null)
                {
                    (Master as Main).Show_Alert("ID is null!", "error");
                }
                else
                {
                    try
                    {
                        movieSession = (new CinemaContext()).MovieSessions.Find(int.Parse(MovieSessionID));

                        if (movieSession != null) InitializeSeatReservationPage();

                    }
                    catch (Exception ex)
                    {
                        (Master as Main).Show_Alert("No Movie Session found!\n\n" + ex.Message, "error");
                    }
                }
            } else
            {
                movieSession = (new CinemaContext()).MovieSessions.Find(int.Parse(Request.QueryString["id"]));
                ViewState["SelectedSeatIndexes"] = SelectedSeatIndexes;
            }

        }

        private void InitializeSeatReservationPage()
        {
            // Get Reserved Seats
            var ReservedSeatIndexes = new List<int>();
            foreach (var reservation in movieSession.Reservations)
                ReservedSeatIndexes.Add(reservation.Seat.Number);

            // Create a list for displaying reserved and not reserved seats
            var SeatsToDisplay = new List<string>();

            // Loop through all seats and check if it's in the reserved seat list
            for (int i = 0; i < movieSession.Stage.Seats.Count; i++)
                if (ReservedSeatIndexes.Contains(i))
                    SeatsToDisplay.Add("~/Content/images/seat-red.png");
                else
                    SeatsToDisplay.Add("~/Content/images/seat-black.png");
            
            Seats.DataSource = SeatsToDisplay;
            Seats.DataBind();
        }

        protected void Seats_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

            // Check if seat is not reserved
            if (!((ImageButton)e.CommandSource).ImageUrl.Equals("~/Content/images/seat-red.png"))
            {
                // Check if seat wasn't already selected
                if (!SelectedSeatIndexes.Contains(e.Item.ItemIndex))
                {
                    // Add it to the selected list
                    SelectedSeatIndexes.Add(e.Item.ItemIndex);
                    ((ImageButton)e.CommandSource).ImageUrl = "~/Content/images/seat-green.png";
                }
                else
                {
                    // Remove it from the selected list
                    SelectedSeatIndexes.Remove(e.Item.ItemIndex);
                    ((ImageButton)e.CommandSource).ImageUrl = "~/Content/images/seat-black.png";
                }

                // Show some info
                (Master as Main).Show_Alert("Number of seats selected: <strong>" + SelectedSeatIndexes.Count+ "</strong> ----- Price to pay: <strong>" + (SelectedSeatIndexes.Count * movieSession.Price ) + " DKK</strong>", "info");
            }
        }

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            // Store info to Session Variables
            Session["SelectedMovieSessionID"] = movieSession.Id;
            Session["SelectedSeatIndexes"] = SelectedSeatIndexes;

            // Redirect to payment page
            Response.Redirect("Payment.aspx");
        }
    }
}
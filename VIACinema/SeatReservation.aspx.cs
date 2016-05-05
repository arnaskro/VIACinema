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
        MovieSession movieSession;
        List<Seat> SeatList;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (ViewState["SelectedSeats"] != null)
                SeatList = (List<Seat>)ViewState["SelectedSeats"];
            else
                SeatList = new List<Seat>();

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
                ViewState["SelectedSeats"] = SeatList;
            }

        }

        private void InitializeSeatReservationPage()
        {
            Seats.DataSource = movieSession.Stage.Seats;
            Seats.DataBind();
        }

        protected void Seats_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

            (Master as Main).Show_Alert(SeatList.Count+"", "info");

            Seat seat = movieSession.Stage.Seats.ToList()[e.Item.ItemIndex];

            if (!SeatList.Contains(seat))
            {
                SeatList.Add(seat);
                ((ImageButton)e.CommandSource).ImageUrl = "~/Content/images/seat-green.png";
            }
            else
            {
                SeatList.Remove(seat);
                ((ImageButton)e.CommandSource).ImageUrl = "~/Content/images/seat-black.png";
            }
        }
    }
}
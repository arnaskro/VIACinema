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

            } catch (Exception ex)
            {
                (Master as Main).Show_Alert("Error while loading data!", "error");
            }

            InfoMovie.InnerHtml = movieSession.Movie.Title + " <small>("+ movieSession.Movie.ReleaseYear +")</small>";
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
                var creditCards = ((User)Session["User"]).CreditCards;

                if (creditCards.Count > 0)
                {
                    CreditCardSelect.Visible = true;
                    CreditCardList.DataSource = ((User)Session["User"]).CreditCards;
                }
            }
        }
    }
}
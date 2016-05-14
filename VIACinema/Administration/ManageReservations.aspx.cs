using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VIACinema.Models;

namespace VIACinema.Administration
{
    public partial class ManageReservations : System.Web.UI.Page
    {
        private List<Reservation> reservations;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Session["user"] != null)
                {
                    reservations = new CinemaContext().Reservations.ToList();
                    loadReservations();
                }
                else
                {
                    Server.Transfer("/Home.aspx", true);
                }
            }
        }
        private void loadReservations()
        {
            if (reservations.Count > 0)
            {
                ListReservations.DataSource = reservations;
                ListReservations.DataBind();

            }
            else
            {
                ReservationPanelBody.Visible = true;
                ListReservations.Visible = false;
            }
        }
        protected void ListReservations_ItemCommand(object source, DataListCommandEventArgs e)
        {
            DataListItem item = e.Item;

            int reservationId = int.Parse(((Label)item.FindControl("reservationId")).Text);
            using (var db = new CinemaContext())
            {
                try
                {
                    db.Reservations.Remove(db.Reservations.Find(reservationId));
                    db.SaveChanges();
                    (Master as Main).Show_Alert("Reservation removed!", "info");
                    Response.Redirect("/Administration/ManageReservations.aspx");
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
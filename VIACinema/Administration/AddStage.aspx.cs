using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VIACinema.Models;

namespace VIACinema.Administration
{
    public partial class AddStage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Session["user"] == null) || (((User)Session["user"]).Admin == false))
            {
                Server.Transfer("/Home.aspx", true);
            }
        }

        protected void SubmitAddStage_Click(object sender, EventArgs e)
        {
            using (var db = new CinemaContext())
            {

                try
                {
                    var title = InputTitle.Text;
                    //var numberOfSeats = int.Parse(InputMaxSeats.ToString());
                    var numberOfSeats = InputMaxSeats.Text;

                    var stage = new Stage();
                    stage.Title = title;
                    stage.MaxNumberOfSeats = int.Parse(numberOfSeats);
                    
                    db.Stages.Add(stage);

                    db.SaveChanges();

                    for (int i = 0; i < stage.MaxNumberOfSeats; i++)
                    {
                        var seat = new Seat();
                        seat.Number = i;
                        seat.Stage = stage;
                        db.Seats.Add(seat);
                    }


                    db.SaveChanges();

                    (Master as Main).Show_Alert("Stage "+ InputTitle.Text + " added successfully!", "success");
                }
                catch (Exception ex)
                {
                    (Master as Main).Show_Alert(ex.Message, "error");
                }

            }
        }
    }
}
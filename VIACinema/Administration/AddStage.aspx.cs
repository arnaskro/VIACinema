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

        }

        protected void SubmitAddStage_Click(object sender, EventArgs e)
        {
            using (var db = new CinemaContext())
            {

                try
                {
                    var title = InputTitle.Text;
                    //var numberOfSeats = int.Parse(InputMaxSeats.ToString());
                    var numberOfSeats = Convert.ToInt32(InputMaxSeats.ToString());

                    var stage = new Stage();
                    stage.Title = title;
                    stage.MaxNumberOfSeats = numberOfSeats;
                    
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
                    
                    Master.FindControl("AlertError").Visible = false;
                    Master.FindControl("AlertSuccess").Visible = true;
                    ((Label)Master.FindControl("AlertSuccessLabel")).Text = "Stage & Seats added successfully!";
                }
                catch (Exception ex)
                {
                    Master.FindControl("AlertError").Visible = true;
                    Master.FindControl("AlertSuccess").Visible = false;
                    ((Label)Master.FindControl("AlertErrorLabel")).Text = ex.Message;
                }

            }
        }
    }
}
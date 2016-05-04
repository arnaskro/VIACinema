using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VIACinema.Models;

namespace VIACinema.Administration
{
    public partial class AddMovieSession : System.Web.UI.Page
    {
        private List<Movie> movieList = null;
        private List<Stage> stageList = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Session["user"] == null) || (((User)Session["user"]).Admin == false))
            {
                Server.Transfer("/Home.aspx", true);
            } else
            {

                InitializeLists();

                if (!Page.IsPostBack)
                {
                    using (var db = new CinemaContext())
                    {
                        // Initialize Movie List
                        var movieQuery = from q
                                    in db.Movies
                                         select q;

                        movieList = movieQuery.ToList();

                        Movie fakeMovie = new Movie();
                        fakeMovie.Title = "-- Select a movie --";
                        fakeMovie.Id = -1;
                        movieList.Insert(0, fakeMovie);

                        InputMovie.DataSource = movieList;
                        InputMovie.DataTextField = "Title";
                        InputMovie.DataValueField = "Id";
                        InputMovie.DataBind();


                        // Initialize Stage List
                        var stageQuery = from q
                                in db.Stages
                                         select q;

                        stageList = stageQuery.ToList();

                        Stage fakeStage = new Stage();
                        fakeStage.Title = "-- Select a stage --";
                        fakeStage.Id = -1;
                        stageList.Insert(0, fakeStage);

                        InputStage.DataSource = stageList;
                        InputStage.DataTextField = "Title";
                        InputStage.DataValueField = "Id";
                        InputStage.DataBind();

                    }
                }

            }
        }


        private void InitializeLists()
        {
            using (var db = new CinemaContext())
            {
                // Initialize Movie List
                var movieQuery = from q
                                in db.Movies
                                 select q;

                movieList = movieQuery.ToList();


                // Initialize Stage List
                var stageQuery = from q
                                 in db.Stages
                                 select q;

                stageList = stageQuery.ToList();
            }
        }

        protected void SubmitAddMovieSession_Click(object sender, EventArgs e)
        {
            using (var db = new CinemaContext())
            {
                try
                {

                    var MovieId = int.Parse(InputMovie.SelectedValue);
                    var StageId = int.Parse(InputStage.SelectedValue);
                    var TicketPrice = double.Parse(InputPrice.Text);
                    var SessionAirDate = Convert.ToDateTime(InputSessionDate.Text);
                    var SessionAirTime = (TimeSpan)InputSessionTime.Text.ToTimeSpan();

                    if (MovieId == 0) throw new Exception("Movie wasn't selected!");
                    else if (StageId == 0) throw new Exception("Stage wasn't selected!");

                    var movieSession = new MovieSession();
                    movieSession.Price = TicketPrice;
                    movieSession.SessionDate = SessionAirDate;
                    movieSession.Time = SessionAirTime;
                    movieSession.MovieId = MovieId;
                    movieSession.StageId = StageId;

                    db.MovieSessions.Add(movieSession);
                    db.SaveChanges();

                    (Master as Main).Show_Alert("Movie Session added successfully!", "success");
                }
                catch (Exception ex)
                {
                    (Master as Main).Show_Alert(ex.Message, "error");
                }

            }
        }
    }
}
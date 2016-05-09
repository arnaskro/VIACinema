using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VIACinema.Models.ServiceModels
{
    public class MovieS
    {

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ReleaseYear { get; set; }
        public string ImageUrl { get; set; }

    }
}
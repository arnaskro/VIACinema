using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VIACinema.Models.ServiceModels
{
    public class MovieSessionS
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public DateTime SessionDate { get; set; }
        public int MovieId { get; set; }
        public int StageId { get; set; }
    }
}
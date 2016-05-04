using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VIACinema
{
    public static class Helper
    {
        public static TimeSpan ToTimeSpan(this string timeString)
        {
            var dt = DateTime.Parse(timeString);
            return dt.TimeOfDay;
        }
    }
}
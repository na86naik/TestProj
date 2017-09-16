using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FitnessAchieve.Models
{
    public class Events
    {
        public int EventId { get; set; }
        public DateTime Date { get; set; }
        public string EventDescription { get; set; }

        public string EventLocation { get; set; }

    }
}
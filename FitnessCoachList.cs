using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FitnessAchieve.Models
{
    public class FitnessCoachList
    {
        public int CoachId { get; set; }
        public string CoachName { get; set; }

        public string CoachExpertise { get; set; }

        public string ContactNo { get; set; }
    }
}
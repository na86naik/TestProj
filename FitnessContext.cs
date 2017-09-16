using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FitnessAchieve.Models
{
    public class FitnessContext : DbContext
    {
        public DbSet<FitnessCoachList> CoachList { get; set; }
    }
}
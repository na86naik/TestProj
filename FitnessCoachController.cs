using FitnessAchieve.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FitnessAchieve.Controllers
{
    public class FitnessCoachController : Controller
    {
        public List<FitnessCoachList> Coaches;
        
        // GET: FitnessCoach
        public ActionResult Index()
        {
            Coaches = new List<Models.FitnessCoachList>();
            FitnessCoachList coach = new Models.FitnessCoachList();
            coach.CoachName = "Coach1";
            coach.CoachExpertise = " DescriptionDescriptionDescriptionDescriptionDescriptionDescriptionDescriptionDescription";
            coach.CoachId = 1;
            coach.ContactNo = "111-111-111";
            Coaches.Add(coach);

            coach = new Models.FitnessCoachList();
            coach.CoachName = "Coach2";
            coach.CoachExpertise = " DescriptionDescriptionDescriptionDescriptionDescriptionDescriptionDescriptionDescription";
            coach.CoachId = 2;
            coach.ContactNo = "222-222-222";
            Coaches.Add(coach);

            coach = new Models.FitnessCoachList();
            coach.CoachName = "Coach3";
            coach.CoachExpertise = " DescriptionDescriptionDescriptionDescriptionDescriptionDescriptionDescriptionDescription";
            coach.CoachId = 3;
            coach.ContactNo = "333-333-333";
            Coaches.Add(coach);

            return View(Coaches);

            //FitnessContext  fitnessContext = new FitnessContext();

            //var data = fitnessContext.CoachList;
            //return View(data.ToList());
        }

        // GET: FitnessCoach/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FitnessCoach/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FitnessCoach/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: FitnessCoach/Edit/5
        public ActionResult Edit(int id)
        {
            //SqlConnection conn = new SqlConnection("");
            //try
            //{
            //    conn.Open();
            //    SqlCommand cmd = new SqlCommand(string.Format("Update tbl_UserDetails Set TrainerId = {0} where userid = {1}", id, string.Empty));
            //    cmd.ExecuteNonQuery();
            //}
            //catch
            //{
            //    conn.Close();
            //}
            Coaches = new List<Models.FitnessCoachList>();
            FitnessCoachList coach = new Models.FitnessCoachList();
            coach.CoachName = "Coach1";
            coach.CoachExpertise = " DescriptionDescriptionDescriptionDescriptionDescriptionDescriptionDescriptionDescription";
            coach.CoachId = 1;
            coach.ContactNo = "111-111-111";
            Coaches.Add(coach);

            coach = new Models.FitnessCoachList();
            coach.CoachName = "Coach2";
            coach.CoachExpertise = " DescriptionDescriptionDescriptionDescriptionDescriptionDescriptionDescriptionDescription";
            coach.CoachId = 2;
            coach.ContactNo = "222-222-222";
            Coaches.Add(coach);

            coach = new Models.FitnessCoachList();
            coach.CoachName = "Coach3";
            coach.CoachExpertise = " DescriptionDescriptionDescriptionDescriptionDescriptionDescriptionDescriptionDescription";
            coach.CoachId = 3;
            coach.ContactNo = "333-333-333";
            Coaches.Add(coach);

            return View(Coaches);
        }

        // POST: FitnessCoach/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: FitnessCoach/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FitnessCoach/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

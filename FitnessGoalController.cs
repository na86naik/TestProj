using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication1.Controllers
{
    public class FitnessGoalController : Controller
    {
        string connection = "datasource; integrated security= true; username = ; password = ;";
        
        public ActionResult Index()
        {
            //if (Session["UserId"] != null)
            //{
            //    return View("FitnessGoal");

            //}
            return View("FitnessGoal");
        }

        [HttpPost]
        public ActionResult FitnessGoal(FitnessGoal obj)
        {
            
            int userId =Convert.ToInt32( Session["UserId"]);
            using (SqlConnection con = new SqlConnection(connection))
            {
                using (SqlCommand cmd = new SqlCommand("USP_CreateGoal", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Days", SqlDbType.Int).Value = obj.Days;
                    cmd.Parameters.Add("@Walk", SqlDbType.Int).Value = obj.Walk;
                    cmd.Parameters.Add("@Run", SqlDbType.Int).Value = obj.Run;
                    cmd.Parameters.Add("@Exercise", SqlDbType.Int).Value = obj.Exercise;
                    cmd.Parameters.Add("@Calories", SqlDbType.Int).Value = obj.Calories;
                    cmd.Parameters.Add("@User", SqlDbType.Int).Value = userId;

                    con.Open();
                    cmd.ExecuteNonQuery();

                }
            }
            return View("Leaderboard");
        }

        //// GET: FitnessGoal/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: FitnessGoal/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: FitnessGoal/Create
        //[HttpPost]
        //public ActionResult Create(FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: FitnessGoal/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: FitnessGoal/Edit/5
        //[HttpPost]
        //public ActionResult Edit(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: FitnessGoal/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: FitnessGoal/Delete/5
        //[HttpPost]
        //public ActionResult Delete(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        }
    }

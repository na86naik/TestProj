using FitnessAchieve.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FitnessAchieve.Controllers
{
    public class EventController : Controller
    {
        // GET: Event
        public ActionResult Index()
        {
            List<Events> eventdescs = new List<Models.Events>();
            Events eventdesc = new Models.Events();
            eventdesc.Date = DateTime.Now;
            eventdesc.EventDescription = " DescriptionDescriptionDescriptionDescriptionDescriptionDescriptionDescriptionDescription";
            eventdesc.EventLocation = "Bangalore";
            eventdesc.EventId = 1;
            eventdescs.Add(eventdesc);

            eventdesc = new Models.Events();
            eventdesc.Date = DateTime.Now;
            eventdesc.EventDescription = " DescriptionDescriptionDescriptionDescriptionDescriptionDescriptionDescriptionDescription";
            eventdesc.EventLocation = "Hyderabad";
            eventdesc.EventId = 2;
            eventdescs.Add(eventdesc);

            eventdesc = new Models.Events();
            eventdesc.Date = DateTime.Now;
            eventdesc.EventDescription = " DescriptionDescriptionDescriptionDescriptionDescriptionDescriptionDescriptionDescription";
            eventdesc.EventLocation = "Mumbai";
            eventdesc.EventId = 3;
            eventdescs.Add(eventdesc);

            return View(eventdescs);

            return View();
        }

        // GET: Event/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Event/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Event/Create
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

        // GET: Event/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Event/Edit/5
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

        // GET: Event/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Event/Delete/5
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

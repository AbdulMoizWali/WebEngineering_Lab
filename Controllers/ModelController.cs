using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebEngineering.Models;

namespace WebEngineering.Controllers
{
    public class ModelController : Controller
    {
        WebEngineeringEntities1 db = new WebEngineeringEntities1();

        // GET: Model
        public ActionResult Index()
        {
            return View(db.Persons.ToList());
        }

        public ActionResult Create() {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Person person)
        {
            if (ModelState.IsValid) {
                db.Persons.Add(person);
                db.SaveChanges();
                return RedirectToAction("index");
            }
            return View();
        }
    }
}
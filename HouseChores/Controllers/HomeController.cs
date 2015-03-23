using HouseChores.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HouseChores.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            DB db = new DB();
            return View(db);
        }

        public ActionResult Kitchen()
        {
            DB db = new DB();
            return View(db.KitchenChores);
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
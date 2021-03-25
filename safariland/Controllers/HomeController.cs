using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace safariland.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        public ActionResult Kanban()
        {
            ViewBag.Message = "Your Kanban page.";

            return View();
        }

        public ActionResult OrderDetails()
        {
            ViewBag.Message = "Your Order Details page.";

            return View();
        }
        public ActionResult OrderAdd()
        {
            ViewBag.Message = "User add to the db";
            return View();
        }
        public ActionResult OrderUpdate()
        {
            ViewBag.Message = "User Update or change order";
            return View();
        }
    }
}
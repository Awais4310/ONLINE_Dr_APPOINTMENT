using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ONLINE_Dr_APPOINTMENT.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        } public ActionResult indexadmin()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult about()
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
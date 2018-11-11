using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MissionForum.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MissionList()
        {
            return View();
        }

        public ActionResult Seoul()
        {
            ViewBag.name = "Seoul Korea South Mission";
            ViewBag.president = "Roger W. Turner";
            ViewBag.address = "29 Wiryeseong-daero 22-gil (Ogeum - dong) Songpa - gu Seoul - teukbyeolsi 05655 South Korea";
            ViewBag.language = "Korean";
            ViewBag.climate = "Subtropical";
            ViewBag.dominate = "Atheist";
            ViewBag.flag = "/Content/Images/korea.png";
            return View("Mission");
        }

        public ActionResult Montreal()
        {
            ViewBag.name = "Canada Montreal Mission";
            ViewBag.president = "Robert Lee Phillips";
            ViewBag.address = "470 Rue Gilford, Montréal, QC H2J 1N3, Canada";
            ViewBag.language = "French";
            ViewBag.climate = "Continental";
            ViewBag.dominate = "Catholic";
            ViewBag.flag = "/Content/Images/quebec.png";
            return View("Mission");
        }

        public ActionResult Lubbock()
        {
            ViewBag.name = "Texas Lubbock Mission";
            ViewBag.president = "David G. Hales";
            ViewBag.address = "6310 114th St, Lubbock, Texas";
            ViewBag.language = "Spanish/English";
            ViewBag.climate = "Semi-arid";
            ViewBag.dominate = "Baptist";
            ViewBag.flag = "/Content/Images/texas.png";
            return View("Mission");
        }

        public ActionResult About()
        {
            ViewBag.Message = "About us!";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
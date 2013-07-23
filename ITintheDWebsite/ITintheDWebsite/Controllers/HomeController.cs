using ITintheDWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITintheDWebsite.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDBContext db = new ApplicationDBContext();

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Who()
        {
            return View();
        }
        public ActionResult What()
        {
            return View();
        }

        public ActionResult Learning()
        {
            return View();
        }

        public ActionResult Gain()
        {
            return View();
        }

        public ActionResult Why()
        {
            return View();
        }

        public ActionResult Apply()
        {


            return View();
        }

        [HttpPost]
        public ActionResult Apply(Application a)
        {
            if (ModelState.IsValid)
            {
                db.Apps.Add(a);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }
    }
}

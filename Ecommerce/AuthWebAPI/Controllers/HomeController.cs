using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;

namespace AuthWebAPI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        public ActionResult getuser()
        {
            var result = new
            {
                Email = "yashvalvi334@gmail.com",
                Password = "70586463"


            };
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}

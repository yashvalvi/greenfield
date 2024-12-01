using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HDFCBankApp.Controllers
{
    public class AuthController : Controller
    {
        // GET: Auth
        public ActionResult Login()
        {
            return View();
        }

        //Post: Auth
        [HttpPost]
        public ActionResult Login(string email,string password)
        {
            if(email=="yashvalvi334@gmail.com" && password == "seed")
            {
                this.HttpContext.Session["loggedinUser"] = email;
                return RedirectToAction("welcome");
            }
            else
            {
                return View();  
            }
        }

        public ActionResult Welcome()
        {
            string email = this.HttpContext.Session["loggedinUser"] as string;
            ViewBag.Email = email;
            return View();
        }
    }
}
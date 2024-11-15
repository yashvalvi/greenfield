using HDFCBankApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace HDFCBankApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string company = "Simplify Healthcare";
            ViewBag.Company = company;
            return View();
        }



        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            Contact cnt = new Contact
            {
                ContactNumber = "705896461",
                Email = "SimplifyHealthcare334@gmail.com",
                Website = "www.SimplifyHealthcare.com"

           

        };
        ViewData["contact"] = cnt;
            return View();


    }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Thankyou()
        {
            // ViewBag.Message = "thank you";
            // return View();
            string theMessage = TempData["mymessage"] as string;
            ViewData["processmessage"]=theMessage;
            return View();  
        }
    }
}
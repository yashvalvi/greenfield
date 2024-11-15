﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HDFCBankApp.Controllers
{
    public class AccountsController : Controller
    {
        // GET: Accounts
        public ActionResult Index()
        {
            string theMessage = "I am manager responsible for approval of account transaction";
            TempData["mymessage"] = theMessage;
            //return View();  
            return RedirectToAction("thankyou","home");   
        }
        public ActionResult Process()
        {
            string theMessage = TempData["mymessage"] as string;
            ViewData["processmessage"]=theMessage;
            return View();
        }
    }
}
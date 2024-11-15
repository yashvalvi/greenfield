using BankingPortal.Models;
using BankingPortal.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace BankingPortal.Controllers
{
    public class AuthController : Controller
    {
        AuthService authService;
        public AuthController()
        {
            authService = new AuthService();
           // authService.Seeding();
        }
        // GET: Auth
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Welcome()
        {
            return View();
        }
        //Post : Auth
        [HttpPost]
        public ActionResult Login(string email, string password)
        {
            if (email == "yashvalvi334@gmail.com" && password == "seed")
            {
                return RedirectToAction("welcome");
            }
            else
            {
                return View();
            }
        }
        public ActionResult Register()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Register(String firstname, string lastname, string email, string Contactno, string location, string password)
        {
            User user = new User
            {
                FirstName = firstname,
                LastName = lastname,
                Email = email,
                ContactNo = Contactno,
                Location = location,
                password = password

            };
            AuthService svc = new AuthService();
            if (svc.Register(user))
            {
                return RedirectToAction("welcome");
            }
            return View();

        }
    }
}


  
 

      
    
    

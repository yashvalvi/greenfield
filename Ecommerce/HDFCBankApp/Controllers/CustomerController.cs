using HDFCBankApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HDFCBankApp.Controllers
{
    public class CustomerController : Controller
    {
       private List<Customer> list = new List<Customer>();

        public CustomerController()
        {
            
            list.Add(new Customer { Id = 1, Name = "Yash Valvi", Email = "yashvalvi334@gmail.com", Location = "Pune" });
            list.Add(new Customer { Id = 1, Name = "Yash Valvi", Email = "yashvalvi334@gmail.com", Location = "Pune" });
            list.Add(new Customer { Id = 1, Name = "Yash Valvi", Email = "yashvalvi334@gmail.com", Location = "Pune" });
            list.Add(new Customer { Id = 1, Name = "Yash Valvi", Email = "yashvalvi334@gmail.com", Location = "Pune" });





        }
        // GET: Customer
        public ActionResult Index()
        {
          
            ViewData["list"] = list;
            return View();
        }


    }
}
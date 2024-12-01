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
            list.Add(new Customer { Id = 2, Name = "Sam", Email = "Sam334@gmail.com", Location = "Mumbai" });
            list.Add(new Customer { Id = 3, Name = "Ali", Email = "Ali334@gmail.com", Location = "Bangalore" });
   
        }
        // GET: Customer
        public ActionResult Index()
        {

            ViewData["list"] = list;
            return View();
        }

        public ActionResult Details(int id)
        {
            Customer customer = list.Find(cust => cust.Id == id);
            return View(customer);
        }


    }
}
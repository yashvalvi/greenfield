using Ecommerceweb1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace Ecommerceweb1.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            List<Customer> customer = new List<Customer>();
            customer.Add(new Customer { Id = 1, FirstName = "Yash", LastName = "Valvi", Email = "yashvalvi334@gmail.com", ContactNo = "7058964631" });
            customer.Add(new Customer { Id = 1, FirstName = "Sam", LastName = "Deshmukh", Email = "patil@gmail.com", ContactNo = "1234567890" });
            customer.Add(new Customer { Id = 1, FirstName = "Gauri", LastName = "Takilkar", Email = "sam@gmail.com", ContactNo = "9876543210" });
            customer.Add(new Customer { Id = 1, FirstName = "Sumedh", LastName = "dixit", Email = "tyafey@gmail.com", ContactNo = "4512789632" });
            customer.Add(new Customer { Id = 1, FirstName = "ayushka", LastName = "patil", Email = "ftqyet@gmai.com", ContactNo = "7418529632" });

            return View(customer);
        }
    }
}



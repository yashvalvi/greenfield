using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HRPortal.Models;

namespace HRPortal.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: Employees
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Details(int id)
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            string firstName = collection["firstname"] as string;
            string lastname = collection["lastname"] as string;
            string email = collection["contactnumber"] as string;
            string contactNumber = collection["email"] as string;
            return View();

        }
        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert(Employee emp) {
            return View();
        }
        public ActionResult Update(int id)
        {
            Employee employee = new Employee();
            employee.Id = id;
            employee.Name = "Rajiv kapoor";
            employee.IsConfirmed = true;
            employee.DailyAllowance = 400;
            employee.BasicSalary = 14000;
            employee.JoinDate = DateTime.Now;   

            return View(employee);
        }
        [HttpPost]
        public ActionResult Update(Employee emp) {






            return View();
        }



    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using catalogue;
namespace Ecommerceweb1.Controllers
  
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
        List<product> products = new List<product>();
        products.Add(new product { Id = 1, Name = "Jaya", Description = "wedding", ProductId = 4, ProductName = "phone", Unitprice = "450", images = "/images/Gerbera.jfif" });
        products.Add(new product { Id = 2, Name = "jasmine", Description = "wedding", ProductId = 4, ProductName = "phone", Unitprice = "450" });
        products.Add(new product { Id = 3, Name = "Rose", Description = "wedding", ProductId = 4, ProductName = "phone", Unitprice = "450" });

        return View(products);
     
        }
        public ActionResult Details()
        {
            return View();  
        }
        public ActionResult Insert()
        {
            return View();
        }
        public ActionResult Update()
        {
            return View();
        }
        public ActionResult Delete() {
            return View();
        }
    }
}
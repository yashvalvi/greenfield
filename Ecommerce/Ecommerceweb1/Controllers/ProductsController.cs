using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ECommerceEntities;
using Specification;
using Services;
namespace Ecommerceweb1.Controllers
  
  
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            //   List<Product> products = new List<Product>();
            //   products.Add(new Product { Id = 1, Name = "Jaya", Description = "wedding", ProductId = 4, ProductName = "phone", UnitPrice = 876, images = "/images/Gerbera.jfif" });
            //   products.Add(new Product { Id = 2, Name = "jasmine", Description = "wedding", ProductId = 4, ProductName = "phone", UnitPrice = 564 });
            //   products.Add(new Product { Id = 3, Name = "Rose", Description = "wedding", ProductId = 4, ProductName = "phone", UnitPrice = 654 });


            //  return View(products);
            //  IProductService productservice = new ProductService();
            //  List<Product> products = new List<Product>();
            //  products = ProductService.GetAll();
            //  return View(products);
            return View();

        }
        public ActionResult Details()
        {
           // IProductService productService = new ProductService();
           // Product product = productService.Get(Id);
           // return View(product);

            

            
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
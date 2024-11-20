using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ecommerceweb1.Controllers
{
    public class ShoppingCartController : Controller
    {
        // GET: ShoppingCart
        public class ShoppingcartController : Controller
        {
            // GET: Shoppingcart
            public ActionResult Index()
            {
                return View();
            }
            public ActionResult AddtoCart() { return View(); }
            public ActionResult RemoveFromCart() { return View(); }

        }
    }
}
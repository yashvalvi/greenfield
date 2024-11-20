using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HRPortal.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
          //  try
          //  {
          //      throw new NotImplementedException("sorry for inconvience");
          //
          //      //   catch(Exception e) {
          //      //  e.Message();
          //      // }
          //  }



            return View();

        }
        public ActionResult About()
        {
                ViewBag.Message = "Your application description page.";

                return View();
        }

         public ActionResult Contact()
            {
                ViewBag.Message = "Your contact page.";

                return View();
            }
        }
    }

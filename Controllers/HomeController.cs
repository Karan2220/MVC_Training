using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string str)
        {
            string filepath = "";

            if (str == "sample.pdf")
            {               
                filepath = "~/Files/sample.pdf";
                return File(filepath, "application/pdf");        
            }
            else if (str == "gotoabout")
            {
                return RedirectToAction("About", "Home");
            }
            else if(str == "login")
            {
                return View("Index");
            }
            else if(str!= null)
            {
                return Content("You entered:" + str);
            }
            else
            {
                return Content("");
            }       
        }

        public ActionResult About()
        {
            return Content("About content here");
        }

    }
}
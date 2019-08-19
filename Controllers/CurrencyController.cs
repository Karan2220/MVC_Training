using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class CurrencyController : Controller
    {
        public ActionResult Index(int amount)
        {
            int[] currencyNotes = new int[] { 1000, 500, 100, 50, 10, 5, 1 };
            int[] counter = new int[10];

           for(int i=0;i<=6;i++)
            {                
                counter[i] = amount / currencyNotes[i];
                amount = amount - counter[i] * currencyNotes[i];
            }
           
            for (int i = 0; i <=9; i++)
            {
                if(counter[i]!=0)
                {
                    ViewBag.counter = counter[i];
                    ViewBag.actualValue = currencyNotes[i];
                }
            }

            ViewBag.text = "";
            int value = 0;
            switch(value)
            { 
                case 1000: ViewBag.text = "Thousand rupees notes";
                    break;
                case 500:
                    ViewBag.text = "Five hundred rupees notes";
                    break;
                case 100:
                    ViewBag.text = "Hundred rupees notes";
                    break;
                case 50:
                    ViewBag.text = "Fifty rupees notes";
                    break;
                case 10:
                    ViewBag.text = "Ten rupees notes";
                    break;
                case 5:
                    ViewBag.text = "Five rupees notes";
                    break;
                case 1:
                    ViewBag.text = "One rupee notes";
                    break;
                default:
                    break;
            }
            return View();
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using System;
using leonov_lab11.Models;

namespace leonov_lab11.Controllers
{
    public class CalcServiceController : Controller
    {
        int a;
        int b;
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult PassUsingViewData()
        {
            Random rand = new Random();
            a = rand.Next(11);
            b = rand.Next(11);
            ViewData["Line1"] = "Rand first value: " + a;
            ViewData["Line2"] = "Rand second value: " + b;
            ViewData["Line3"] = "Add:";
            ViewData["Line4"] = a + " + " + b + " = " + (a + b);
            ViewData["Line5"] = "Sub:";
            ViewData["Line6"] = a + " - " + b + " = " + (a - b);
            ViewData["Line7"] = "Mult:";
            ViewData["Line8"] = a + " * " + b + " = " + (a * b);
            ViewData["Line9"] = "Div:";
            ViewData["Line10"] = a + " / " + b + " = " + (b != 0 ? (a / b) : "Division by zero!");
            return View();
        }
        public ActionResult PassUsingModel()
        {
            Random rand = new Random();
            a = rand.Next(11);
            b = rand.Next(11);
            var viewModel = new Actions()
            {
                value1 = a,
                value2 = b,
                subtraction = a - b,
                multiply = a * b,
                sum = a + b,
                divide = (b != 0 ? (a / b) : -1)
            };
            return View(viewModel);
        }
        public ActionResult PassUsingViewBag()
        {
            Random rnd = new Random();
            a = rnd.Next(11);
            b = rnd.Next(11);
            ViewBag.Line1 = "Rand first value: " + a;
            ViewBag.Line2 = "Rand second value: " + b;
            ViewBag.Line3 = "Add:";
            ViewBag.Line4 = a + " + " + b + " = " + (a + b);
            ViewBag.Line5 = "Sub:";
            ViewBag.Line6 = a + " - " + b + " = " + (a - b);
            ViewBag.Line7 = "Mult:";
            ViewBag.Line8 = a + " * " + b + " = " + (a * b);
            ViewBag.Line9 = "Div:";
            ViewBag.Line10 = a + " / " + b + " = " + (b != 0 ? (a / b) : "Division by zero!");
            return View();
        }
        public ActionResult AccessServiceDirectly()
        {
            return View();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewBagDemo.Models;

namespace ViewBagDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Message = "Message from view bag !!";
            ViewBag.CurrentDate = DateTime.Now.ToLongDateString();
            string[] fruits = { "Apple", "Banana", "Grapes", "Orange" };
            ViewBag.FruitsArray = fruits;
            ViewBag.SportsList = new List<string>()
            {
                "Cricket","Football","Hockey","Baseball"
            };
            Employee obj = new Employee();
                obj.EmpId = 23;
                obj.EmpName = "Krishna";
                obj.EmpDesignation = "HouseWife";

            ViewBag.Employee = obj;
            ViewBag.CommonMessage = "This message is accessible by both viewData and ViewBag";
            return View();
        }
    }
}
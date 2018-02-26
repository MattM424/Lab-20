using Lab20UserRegistration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab20UserRegistration.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        public ActionResult Registration()
        {
            return View();
        }

        public ActionResult Register(CoffeeShopDBEntities NewCustomer)
        {
            CoffeeShopDBEntities MyORM = new CoffeeShopDBEntities();

            MyORM.User.Add(NewCustomer);

            MyORM.SaveChanges();

            Viewbag.FirstName = CoffeeShopDBEntities.Users.[First Name];

            return View("Welcome");
        }

        public ActionResult Welcome()
        {
            return View();
        }
    }
}
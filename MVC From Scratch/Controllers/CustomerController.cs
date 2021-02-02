using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_From_Scratch.Models;

namespace MVC_From_Scratch.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult DisplayCustomer()
        {
            var Customer = new Customer(1, "Doha", "Irbid", 24);
            return View(Customer);
        }

       public ActionResult Create ()
        {
            var cust = new Customer();
            return View(cust);
        }
    }
}
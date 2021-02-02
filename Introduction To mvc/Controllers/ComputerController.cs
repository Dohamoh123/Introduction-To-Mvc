using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Introduction_To_mvc.Models;

namespace Introduction_To_mvc.Controllers
{
    public class ComputerController : Controller
    {
        public ActionResult Display ()
        {
            var MyComputer = new Computer
            {
                Name = "Lenovo LinkPad",
                Price = 500
            };

            return View(MyComputer);
        }
    }
}
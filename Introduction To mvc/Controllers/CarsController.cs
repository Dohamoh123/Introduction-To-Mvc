using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Introduction_To_mvc.Controllers
{
    public class CarsController : Controller
    {
        // GET: Cars
        [Route("Cars/Index")]
        public ContentResult Index ()
        {
            return Content ("<h1> Attribute-Based Routing Demo </h1>");
        }
    }
}
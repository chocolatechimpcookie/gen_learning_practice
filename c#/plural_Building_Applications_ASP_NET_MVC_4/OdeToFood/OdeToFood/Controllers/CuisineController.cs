using OdeToFood.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    public class CuisineController : Controller
    {
        //you can use this attribute to control logic relating to specific userss
        // you can also put this attribute at the class level
        //[Authorize]
        [Log]
        public ActionResult Search(string name = "french")
        {
            var message = Server.HtmlEncode(name);
            return Content(message);

        }

    }
}

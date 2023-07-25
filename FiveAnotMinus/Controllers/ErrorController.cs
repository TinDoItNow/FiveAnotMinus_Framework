using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FiveAnotMinus.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult Error404()
        {
            return View();
        }

        public string Error403()
        {
            return "Error403";
        }
        public string Error500()
        {
            return "Error500";
        }
        public string General()
        {
            return "Error404";
        }
    }
}
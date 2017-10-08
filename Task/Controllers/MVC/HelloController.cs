using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task.Controllers.API;

namespace Task.Controllers.MVC
{
    public class HelloController : Controller
    {
        // GET: Hello
        public ActionResult Index()
        {
            ApiHelloController api = new ApiHelloController();
            ViewBag.Massege = api.Get();
            return View();
        }
    }
}
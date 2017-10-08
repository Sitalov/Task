using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task.Controllers.API;

namespace Task.Controllers.MVC
{
    public class HiController : Controller
    {
        // GET: Hi
        public ActionResult Index()
        {
          ApiHiController api=  new ApiHiController();
          ViewBag.Massege = api.Get();
            return View();
        }
    }
}
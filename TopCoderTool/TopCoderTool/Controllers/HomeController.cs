using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TopCoderTool.Library;
using TopCoderTool.Library.Data;
using TopCoderTool.Models;

namespace TopCoderTool.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new TopUserViewModel();
            model.GetTopUsers();
            return View(model);
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
    }
}
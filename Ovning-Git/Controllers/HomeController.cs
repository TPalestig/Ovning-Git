using Ovning_Git.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ovning_Git.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new TitleModel();
            model.Title = "New Awesome Title";
            
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
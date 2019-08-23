using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GitDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //Test Print Message edited in the remote repo; Checked out Master
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}

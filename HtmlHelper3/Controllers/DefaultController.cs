using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HtmlHelper3.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Addition()
        {
            return View();
        }
    }
}

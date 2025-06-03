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
            ViewBag.msg = TempData["msg"];
            return View();
        }
        [HttpPost]
        public ActionResult Login(FormCollection frm)
        {
            string uname = frm["txtUsername"];
            string Pass = frm["txtPassword"];
            if (uname=="Admin" && Pass=="Admin@123")
            {
                TempData["msg"] = "Login Successful";
            }
            else
            {
                TempData["msg"] = "Invalid User Name of Password!!!";
            }
                return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult Addition()
        {
            int n1 =int.Parse(Request["txtFirstNumber"]);
            int n2 = int.Parse(Request["txtSecondNumber"]);
            int sum = n1 + n2;
            TempData["msg"] = sum;
            return RedirectToAction("Index");
        }
    }
}

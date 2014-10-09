using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using MvcContrib;
namespace HelloCI.Web.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About() {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact() {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Help() {
            return this.RedirectToAction(x => x.About());
        }

        public ActionResult SlowIndex() {
            Thread.Sleep(50000);
            return this.RedirectToAction("Index");
        }

        public ActionResult Fail() {
            var zero = 0;
            var oops = 5/zero;
            return this.RedirectToAction("Index");
        }
    }
}

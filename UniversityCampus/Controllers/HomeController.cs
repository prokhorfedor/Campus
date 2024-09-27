using System.Web.Mvc;
using System;
namespace Campus.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
            Console.WriteLine("Hello World");
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
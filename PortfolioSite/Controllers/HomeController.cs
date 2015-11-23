using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortfolioSite.Controllers
{
    public class HomeController : Controller
    {

        //GET: Reset Session Variable from AJAX 
        public ActionResult SetSession(string session)
        {
            Session["Ponies"] = session;
            return RedirectToAction("Index");   
        }

        // GET: Home
        public ActionResult Index()
        {
            return View(); 
        }

        // GET: About
        public ActionResult About()
        {
            return View();
        }

        // GET: Contact
        public ActionResult Contact()
        {
            return View();
        }
    }
}
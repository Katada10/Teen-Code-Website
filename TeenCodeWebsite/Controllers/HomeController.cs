using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeenCodeWebsite.Models;
using System.Net;
using System.Net.Mail;

namespace TeenCodeWebsite.Controllers
{
    public class HomeController : Controller
    { 
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
        
        public ActionResult Contact()
        {
            return View();
        }     

        public ActionResult Privacy()
        {
            return View();
        }

        public ActionResult TOS()
        {
            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeenCodeWebsite.Models;

namespace TeenCodeWebsite.Controllers
{
    public class SocialController : Controller
    {

        private ApplicationDbContext ctx = new ApplicationDbContext();


        [Authorize(Roles ="Admin")]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddLink(SMLink sm)
        {
            if(ModelState.IsValid)
            {
                ctx.SMLinks.Add(new SMLink() { Name = sm.Name, ImageUrl = sm.ImageUrl, PageUrl = sm.PageUrl });
                ctx.SaveChanges();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
    }
}
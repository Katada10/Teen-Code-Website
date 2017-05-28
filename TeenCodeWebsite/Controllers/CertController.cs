using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeenCodeWebsite.Models;

namespace TeenCodeWebsite.Controllers
{
    public class CertController : Controller
    {
        private ApplicationDbContext ctx = new ApplicationDbContext();

        [Authorize(Roles = "Admin")]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCertification(Certification c)
        {
            if (ModelState.IsValid)
            {
                ctx.Certifications.Add(new Certification { Name = c.Name, IMGURL = c.IMGURL });
                ctx.SaveChanges();
                return RedirectToAction("Index");
            }

            Console.WriteLine("Failed to add cert");
            return View();
        }
    }
}
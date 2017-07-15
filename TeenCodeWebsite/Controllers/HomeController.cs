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

        [HttpPost]
        public ActionResult Contact(ContactForm form)
        {
            if(ModelState.IsValid)
            {
                try
                {
                    var msg = new MailMessage()
                    {
                        From = new MailAddress(form.Email),
                        Subject = form.Subject,
                        Body = form.Message
                    };

                    msg.To.Add("teencodedev@gmail.com");

                    var smtp = new SmtpClient();

                    smtp.Host = ("gmail-smtp-in.l.google.com");
                    

                    smtp.Port = 25;
                    smtp.EnableSsl = true;

                    smtp.UseDefaultCredentials = true;

                    smtp.Send(msg);

                    ModelState.Clear();
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

            return View();
        }        
    }
}
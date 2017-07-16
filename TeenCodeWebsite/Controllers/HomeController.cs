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
            return Redirect("http://localhost:80/redirect/script.php");

            /*
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

                    var split = msg.From.ToString().Split('@');

                    var smtp = new SmtpClient();
                


                    if (split[1] != "yahoo.com")
                    {
                        msg.To.Add("teencodedev@gmail.com");
                        smtp.Host = ("gmail-smtp-in.l.google.com");

                        smtp.Port = 25;
                        smtp.EnableSsl = true;

                        smtp.UseDefaultCredentials = true;

                        smtp.Send(msg);
                        msg.To.Clear() ;

                        ModelState.Clear();
                    }
                    //(split[1] == "yahoo.com")
                    //{
                        msg.To.Add("teencodedev@yahoo.com");
                        smtp.Host = "smtp.mail.yahoo.com";

                        smtp.Port = 465;
                        smtp.EnableSsl = true;

                        smtp.Credentials = new NetworkCredential("teencodedev@gmail.com", "penguin1!");

                        smtp.Send(msg);
                        smtp.Timeout = 1000;

                        msg.To.Clear();
                        ModelState.Clear();
                    //}
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

            return View();*/
        }        
    }
}
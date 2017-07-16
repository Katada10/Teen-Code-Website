using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace EmailTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                var msg = new MailMessage()
                {
                    From = new MailAddress("Sedk239@gmail.com"),
                    Subject = "test",
                    Body = "hello"
                };

                var smtp = new SmtpClient();
                msg.To.Add("teencodedev@gmail.com");
                smtp.Host = "gmail-smtp-in.l.google.com";

                smtp.Port = 25;
                smtp.EnableSsl = true;

                smtp.UseDefaultCredentials = true;

                smtp.Send(msg);
                Console.WriteLine("Send Success");

                msg.To.Clear();

                Console.ReadLine();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
        }
    }
}


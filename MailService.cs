using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace events_delegates
{
    internal class MailService
    {
        public void sendmail(object source,EventArgs e) 
        {
            string fmail = "tarunrk2002@gmail.com";
            string pass_fmail = "xueb bybu ynjl yica";
            int otp = 0;
            Random rand = new Random();
            otp = rand.Next(111, 999);


            MailMessage mailMessage = new MailMessage();

            mailMessage.From = new MailAddress(fmail);
            mailMessage.Subject = "OTP";
            mailMessage.IsBodyHtml = true;
            mailMessage.Body = "<html><body>hi this is your otp: " + otp + "</body></html>";
            mailMessage.To.Add(new MailAddress("tarunrk2002@gmail.com"));


            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(fmail, pass_fmail),
                EnableSsl = true

            };

            try
            {
                smtpClient.Send(mailMessage);



                Console.WriteLine("Email sent successfully.");

            }
            catch (Exception eee)
            {
                Console.WriteLine("failed to send");
            }
            finally
            {
                Console.WriteLine("email triggered...");
            }

        }
    }
}

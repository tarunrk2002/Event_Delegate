using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace events_delegates
{
    internal class MailService
    {
        public void sendmail(object source,EventArgs e) 
        {
            Console.WriteLine("mail sent...");
        }
    }
}

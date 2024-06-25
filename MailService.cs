using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace events_delegates
{
    internal class MailService
    {
        public void OnVideoEncoded()
        {
            Console.WriteLine("sending the mail");
        }
    }
}

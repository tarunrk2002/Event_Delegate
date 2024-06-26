using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace events_delegates
{
    internal class TextMessage
    {
        public void sendingsms(object sender, EventArgs e)
        {
            Thread.Sleep(3000);
            Console.WriteLine("sms sent");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace events_delegates
{
    internal class sendingvoicenote
    {
        public void voicenote(object source,EventArgs e)
        {
            Console.WriteLine("sending voice note..!!");

            Thread.Sleep(1000);
            Console.WriteLine("sent");
        }
    }
}

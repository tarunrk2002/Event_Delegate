using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace events_delegates
{
    internal class encoder
    {
        public void enco(vid vid) 
        {
            Console.WriteLine("encodingg...!!!");
            Thread.Sleep(4000);
        }
    }
}

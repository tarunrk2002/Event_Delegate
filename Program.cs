using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace events_delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            vid vidd = new vid() { Title = "hi" };
            vid vidd2 = new vid() { Title = "hello" };

            encoder encoder = new encoder();
            encoder.enco(vidd);
        }
    }
}

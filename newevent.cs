using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace events_delegates
{
    internal class newevent
    {
        public delegate void AfterCleaningEventHandler(object sender, EventArgs e);
        public event AfterCleaningEventHandler AfterCleaning;

        public void cleaning()
        {
            Console.WriteLine("vacuum started ..!");
            Thread.Sleep(2000);
            Console.WriteLine("cleaning has ended");
            OnAfterCleaning();
        }
        protected virtual void OnAfterCleaning()
        {
            if (AfterCleaning != null)
            {
                AfterCleaning(this, EventArgs.Empty);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace events_delegates
{
    internal class VideoEncoder
    {
        public delegate void VideoEncodedEvenHandler(object source, EventArgs e);
        public event VideoEncodedEvenHandler VideoEncoded;
        public void Encode(Video video) 
        {
            Console.WriteLine("encoding..");
            Thread.Sleep(4000);
            OnVideoEncoded();
        }
        protected virtual void OnVideoEncoded()
        {
            if (VideoEncoded != null)
            {
                VideoEncoded(this, EventArgs.Empty);
            }
        }
    }
}

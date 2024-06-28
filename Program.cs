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
            Video video = new Video() { Title = "hello"};

            VideoEncoder encoder = new VideoEncoder();


            MailService mailService = new MailService();
            encoder.VideoEncoded += mailService.sendmail;


            TextMessage textMessage = new TextMessage();
            encoder.VideoEncoded += textMessage.sendingsms;


            sendingvoicenote svn = new sendingvoicenote();
            encoder.VideoEncoded += svn.voicenote;

            newevent newevent = new newevent();
           
            newevent.AfterCleaning += mailService.sendmail;


            newevent.cleaning();
            encoder.Encode(video);
        }

     
    }
}

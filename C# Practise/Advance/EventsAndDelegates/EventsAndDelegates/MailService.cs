using System;

namespace EventsAndDelegates
{
    public class MailService
    {
        public void OnSendingMailForVedioEncoding(object source, VideoEventArgs e)
        {
            Console.WriteLine("MailService: Sending an email..." + e.video.Title);
        }
    }
}

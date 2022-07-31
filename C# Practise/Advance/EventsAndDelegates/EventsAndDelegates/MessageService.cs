using System;

namespace EventsAndDelegates
{
    public class MessageService
    {
        public void OnSendingMessageForVedioEncoding(object source, VideoEventArgs args)
        {
            Console.WriteLine("MessageService: Sending a text message " + args.video.Title);
        }
    }
}

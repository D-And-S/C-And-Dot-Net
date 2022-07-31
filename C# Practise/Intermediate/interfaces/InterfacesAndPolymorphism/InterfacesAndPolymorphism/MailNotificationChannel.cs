using System;

namespace InterfacesAndPolymorphism
{
    public class MailNotificationChannel : INotifacationChannel
    {
        public void Send(Message message)
        {
            Console.WriteLine("Sending Mail");
        }
    }
    
}

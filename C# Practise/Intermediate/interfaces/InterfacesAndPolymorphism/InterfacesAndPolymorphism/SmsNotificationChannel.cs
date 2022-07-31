using System;

namespace InterfacesAndPolymorphism
{
    public class SmsNotificationChannel : INotifacationChannel
    {
        public void Send(Message message)
        {
            Console.WriteLine("Sending SMS");
        }
    }
    
}

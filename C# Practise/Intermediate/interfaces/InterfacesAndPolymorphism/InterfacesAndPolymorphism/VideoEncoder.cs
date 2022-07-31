using System.Collections.Generic;

namespace InterfacesAndPolymorphism
{

    public class VideoEncoder
    {
        private readonly IList<INotifacationChannel> _notifacationChannels;

        public VideoEncoder()
        {
            _notifacationChannels = new List<INotifacationChannel>();
        }

        public void Encode(Video video)
        {
            foreach (var channel in _notifacationChannels)
            {
                channel.Send(new Message());
            }
        }

        public void RegisterNotificationChannel(INotifacationChannel channel)
        {
            _notifacationChannels.Add(channel);
        }
        
    }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Patterns.Behaviourial.Observer.YoutubeChannel
{
    public class YouTubeChannel : IPublisher
    {
        List<ISubscriber> subscribers = new List<ISubscriber>();

        public void Subscribe(ISubscriber subscriber)
        {
            subscribers.Add(subscriber);
        }

        public void UnSubscrie(ISubscriber subscriber)
        {
            subscribers.Remove(subscriber);
        }

        public void NotifyToSubscribers()
        {
            foreach (ISubscriber subscriber in subscribers)
            {
                subscriber.Notify();
            }
        }

    }
}

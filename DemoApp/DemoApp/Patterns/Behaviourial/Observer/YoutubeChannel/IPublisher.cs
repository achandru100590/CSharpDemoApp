using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Patterns.Behaviourial.Observer.YoutubeChannel
{
    public interface IPublisher
    {
        void Subscribe(ISubscriber subscriber);
        void UnSubscrie(ISubscriber subscriber);
        void NotifyToSubscribers();
    }
}

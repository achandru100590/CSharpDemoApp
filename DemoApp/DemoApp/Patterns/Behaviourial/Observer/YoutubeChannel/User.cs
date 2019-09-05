using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Patterns.Behaviourial.Observer.YoutubeChannel
{
    public class User : ISubscriber
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public void Notify()
        {
            Console.WriteLine(string.Format("{0} got channel's notification", Name));
        }
    }
}

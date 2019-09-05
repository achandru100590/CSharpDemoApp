using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Patterns.Behaviourial.Iterator.SocialNetwork
{
    public interface IIterator
    {
        void First();
        string Next();
        bool isDone();
        string CurrentItem();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Patterns.Behaviourial.Iterator.SocialNetwork
{
    public interface ISocialNetwork
    {
        IIterator CreateIterator();
        
    }
}

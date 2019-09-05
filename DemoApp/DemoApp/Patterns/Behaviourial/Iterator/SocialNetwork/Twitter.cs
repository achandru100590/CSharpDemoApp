using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Patterns.Behaviourial.Iterator.SocialNetwork
{
    public class Twitter : ISocialNetwork
    {
        string[] users;

        public Twitter()
        {
            users = new string[] { "T1", "T2", "T3", "T4", "T5" };
        }

        public IIterator CreateIterator()
        {
            return new TwitterIterator(users);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Patterns.Behaviourial.Iterator.SocialNetwork
{
    public class TwitterIterator : IIterator
    {
        private string[] _users;
        private int curruntPosition = 0;
        public TwitterIterator(string[] users)
        {
            this._users = users;
        }
        public string CurrentItem()
        {
            return _users[curruntPosition];
        }

        public void First()
        {
            curruntPosition = 0;
        }

        public bool isDone()
        {
            return _users.Length <= curruntPosition;
        }

        public string Next()
        {
            return _users[curruntPosition++];
        }
    }
}

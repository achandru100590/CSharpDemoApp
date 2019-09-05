using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Patterns.Behaviourial.Iterator.SocialNetwork
{
    public class FaceBookIterator : IIterator
    {
        private List<string> _users;
        private int currentPosition = 0;
        public FaceBookIterator(List<string> users)
        {
            this._users = users;
        }

        public string CurrentItem()
        {
            return _users[currentPosition];
        }

        public void First()
        {
            currentPosition = 0;
        }

        public bool isDone()
        {
            return currentPosition >= _users.Count;
        }

        public string Next()
        {
            return _users[currentPosition++];
        }
    }
}

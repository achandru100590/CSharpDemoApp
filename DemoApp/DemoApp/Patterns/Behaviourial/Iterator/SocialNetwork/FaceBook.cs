using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Patterns.Behaviourial.Iterator.SocialNetwork
{
    public class FaceBook : ISocialNetwork
    {
        List<string> users = new List<string>();

        public FaceBook()
        {
            users.Add("F1");
            users.Add("F2");
            users.Add("F3");
            users.Add("F4");
            users.Add("F5");
        }

        public IIterator CreateIterator()
        {
            return new FaceBookIterator(users);
        }
    }
}

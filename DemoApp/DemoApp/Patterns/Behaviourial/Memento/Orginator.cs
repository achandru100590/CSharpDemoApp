using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Patterns.Behaviourial.Memento
{
    public class Orginator
    {
        private string _message; 
        public string GetMessage()
        {
            return _message;
        }
        public void SetMessage(string message)
        {
            _message = message;
        }
        public Memento SaveMessage()
        {
            return new Memento(_message);
        }
        public void RestoreMessage(Memento memento)
        {
            this._message = memento.GetMessage();
        }
    }
}

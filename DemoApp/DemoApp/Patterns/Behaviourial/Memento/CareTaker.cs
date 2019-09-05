using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Patterns.Behaviourial.Memento
{
    public class CareTaker
    {
        List<Memento> _mementos = new List<Memento> ();
        int index = -1;
        public void AddMemento(Memento memento)
        {
            index++;
            _mementos.Add(memento);
        }
        public Memento Undo()
        {
            if (index > 0)
            {
                index--;
                Console.WriteLine(string.Format("Undo action is performed.\n"));             

            }

            return _mementos[index];

        }
        public Memento Redo()
        {
            if (_mementos.Count < index)
            {
                index++;
                Console.WriteLine(string.Format("Redo action is performed.\n"));

            }

            return _mementos[index];
        }
        public void GetMessage()
        {
            Console.WriteLine(string.Format("Current Message is {0}.\n", _mementos[index].GetMessage()));
        }
    }
}

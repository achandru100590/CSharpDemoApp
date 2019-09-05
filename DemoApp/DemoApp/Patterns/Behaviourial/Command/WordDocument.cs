using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Patterns.Behaviourial.Command
{
    public class WordDocument
    {
        public void Open()
        {
            Console.WriteLine("File is opened");
        }

        public void Save()
        {
            Console.WriteLine("File is Saved");
        }

        public void Close()
        {
            Console.WriteLine("File is Closed");
        }
    }
}

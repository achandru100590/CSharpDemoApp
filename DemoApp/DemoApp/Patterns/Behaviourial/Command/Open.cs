using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Patterns.Behaviourial.Command
{
    public class Open  : ICommand
    {
        private WordDocument _document;
        public Open(WordDocument document)
        {
            _document = document;

        }
        public void Execute()
        {
            _document.Open();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Patterns.Behaviourial.Command
{
    public class Close : ICommand
    {

        private WordDocument _document;
        public Close(WordDocument document)
        {
            _document = document;

        }
        public void Execute()
        {
            _document.Close();
        }
    }
}

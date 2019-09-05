﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Patterns.Behaviourial.Command
{
    public class Save : ICommand
    {

        private WordDocument _document;
        public Save(WordDocument document)
        {
            _document = document;

        }
        public void Execute()
        {
            _document.Save();
        }
    }
}

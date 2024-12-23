using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class TextMemento
    {
        public string Text { get; private set; }

        public TextMemento(string text)
        {
            Text = text;
        }
    }
}

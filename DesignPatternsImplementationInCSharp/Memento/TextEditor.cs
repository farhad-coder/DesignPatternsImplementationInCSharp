using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class TextEditor
    {
        private string _text;
        public void SetText(string text) { _text = text; }
        public string GetText() { return _text; }
        public TextMemento Save()
        {
            return new TextMemento(_text);
        }
        public void Restore(TextMemento memento)
        {
            _text = memento.Text;
        }
    }
}

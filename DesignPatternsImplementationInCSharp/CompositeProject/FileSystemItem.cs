using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeProject
{
    public abstract class FileSystemItem
    {
        public string Name { get; private set; }

        protected FileSystemItem(string name)
        {
            Name = name;
        }

        public abstract void Display(int depth);
    }
}

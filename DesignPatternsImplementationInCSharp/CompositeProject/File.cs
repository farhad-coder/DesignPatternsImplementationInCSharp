using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeProject
{
    public class File : FileSystemItem
    {
        public File(string name) : base(name) { }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + Name);
        }
    }
}

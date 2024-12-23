using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorProject
{
    public class ConcreteVisitor2 : IVisitor
    {
        public void Visit(ElementA element)
        {
            Console.WriteLine($"{element.OpertaionA()} visited by ConcreteVisitor2");
        }

        public void Visit(ElementB element)
        {
            Console.WriteLine($"{element.OpertaionB()} visited by ConcreteVisitor2");
        }
    }
}

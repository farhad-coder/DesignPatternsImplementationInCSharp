using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorProject
{
    public class ConcreteVisitor1 : IVisitor
    {
        public void Visit(ElementA element)
        {
            Console.WriteLine($"{element.OpertaionA()} visited by ConcreteVisitor1");
        }

        public void Visit(ElementB element)
        {
            Console.WriteLine($"{element.OpertaionB()} visited by ConcreteVisitor1");
        }
    }
}

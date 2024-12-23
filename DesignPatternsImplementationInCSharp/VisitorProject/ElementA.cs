using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorProject
{
    public class ElementA : IElement
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public string OpertaionA()
        {
            return "Operation ElementA";
        }
    }
}

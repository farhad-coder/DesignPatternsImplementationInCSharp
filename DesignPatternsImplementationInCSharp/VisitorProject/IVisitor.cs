using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace VisitorProject
{
    public interface IVisitor
    {
        void Visit(ElementA element);
        void Visit(ElementB element);
    }
}

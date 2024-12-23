using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodProject
{
    public class ConcreteClassB : AbstractClass
    {
        protected override void Step1()
        {
            Console.WriteLine("ConcreteClassB: execute step 1");
        }

        protected override void Step2()
        {
            Console.WriteLine("ConcreteClassB: execute step 2");
        }

        protected override void Step3()
        {
            Console.WriteLine("ConcreteClassB: execute step 3");
        }

        protected override void Hook()
        {
            Console.WriteLine("ConcreteClassB: execute step virtual");
        }
    }
}

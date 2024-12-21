using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodProject
{
    public class Dog : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Haap Haap!");
        }
    }
}

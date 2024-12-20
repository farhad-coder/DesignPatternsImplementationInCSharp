using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    public class Cat : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Meow! Meow!"); ;
        }
    }
}

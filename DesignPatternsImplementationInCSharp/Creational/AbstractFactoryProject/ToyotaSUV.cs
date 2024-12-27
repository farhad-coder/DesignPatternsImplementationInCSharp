using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryProject
{
    public class ToyotaSUV : ISUV
    {
        public void DisplayDetails()
        {
            Console.WriteLine("Toyota SUV: Highlander");
        }
    }
}

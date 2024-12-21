using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryProject
{
    public class FordSUV : ISUV
    {
        public void DisplayDetails()
        {
            Console.WriteLine("Ford SUV: Explorer");
        }
    }
}

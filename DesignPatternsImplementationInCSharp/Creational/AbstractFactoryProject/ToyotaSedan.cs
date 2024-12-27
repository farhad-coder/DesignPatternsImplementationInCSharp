using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryProject
{
    public class ToyotaSedan : ISedan
    {
        public void DisplayDetails()
        {
            Console.WriteLine("Toyota Sedan: Corolla");
        }
    }
}

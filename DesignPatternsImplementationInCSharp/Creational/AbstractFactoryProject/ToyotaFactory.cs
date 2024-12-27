using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryProject
{
    public class ToyotaFactory : ICarFactory
    {
        public ISedan CreateSedan()
        {
            return new ToyotaSedan();
        }

        public ISUV CreateSUV()
        {
            return new ToyotaSUV();
        }
    }
}

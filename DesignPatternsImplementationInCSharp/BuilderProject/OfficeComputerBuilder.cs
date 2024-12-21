using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderProject
{
    public class OfficeComputerBuilder : IComputerBuilder
    {
        private Computer _computer = new Computer();

        public void SetGraphicsCard()
        {
            _computer.GraphicsCard = "Integrated Intel Graphics";
        }

        public void SetProcessor()
        {
            _computer.Processor = "Intel Core i5";
        }

        public void SetRAM()
        {
            _computer.RAM = "16GB";
        }

        public void SetStorage()
        {
            _computer.Storage = "512GB SSD";
        }
        public Computer GetComputer()
        {
            return _computer;
        }
    }
}

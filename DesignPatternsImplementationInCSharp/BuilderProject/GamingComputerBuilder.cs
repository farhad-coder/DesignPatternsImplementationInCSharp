using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderProject
{
    public class GamingComputerBuilder : IComputerBuilder
    {
        private Computer _computer = new Computer();

        public void SetGraphicsCard()
        {
            _computer.GraphicsCard = "NVIDIA GeForce RTX 3080";
        }

        public void SetProcessor()
        {
            _computer.Processor = "Intel Core i9";
        }

        public void SetRAM()
        {
            _computer.RAM = "32GB";
        }

        public void SetStorage()
        {
            _computer.Storage = "1TB SSD";
        }
        public Computer GetComputer()
        {
            return _computer;
        }
    }
}

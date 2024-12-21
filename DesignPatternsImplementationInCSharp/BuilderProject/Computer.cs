using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderProject
{
    public class Computer
    {
        public string Processor { get; set; }

        public string RAM { get; set; }

        public string Storage { get; set; }

        public string GraphicsCard { get; set; }

        public override string ToString()
        {
            return $"Processor: {Processor}, RAM: {RAM}, " +
                   $"Storage: {Storage}, Graphics Card: {GraphicsCard}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeProject
{
    public class Car : ICarPrototype
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public int EngineCapacity { get; set; }

        public Car(string model, string color, int engineCapacity)
        {
            Model = model;
            Color = color;
            EngineCapacity = engineCapacity;
        }
        public ICarPrototype Clone()
        {
            return (ICarPrototype)MemberwiseClone();
        }

        public override string ToString()
        {
            return $"Model: {Model}, Color: {Color}, Engine Capacity: {EngineCapacity} cc";
        }
    }
}

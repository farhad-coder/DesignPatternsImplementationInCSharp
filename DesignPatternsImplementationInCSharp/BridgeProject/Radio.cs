using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeProject
{
    public class Radio : IDevice
    {
        public void PowerOff()
        {
            Console.WriteLine("Radio is now OFF.");
        }

        public void PowerOn()
        {
            Console.WriteLine("Radio is now ON.");
        }

        public void SetChannel(int channel)
        {
            Console.WriteLine($"Radio frequency set to {channel} MHz.");
        }
    }
}

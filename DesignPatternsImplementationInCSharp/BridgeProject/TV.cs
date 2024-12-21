using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeProject
{
    public class TV : IDevice
    {
        public void PowerOff()
        {
            Console.WriteLine("TV is now OFF.");
        }

        public void PowerOn()
        {
            Console.WriteLine("TV is now ON.");
        }

        public void SetChannel(int channel)
        {
            Console.WriteLine($"TV channel set to {channel}.");
        }
    }
}

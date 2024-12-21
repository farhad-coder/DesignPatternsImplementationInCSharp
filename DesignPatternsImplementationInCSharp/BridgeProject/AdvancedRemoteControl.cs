using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeProject
{
    public class AdvancedRemoteControl : RemoteControl
    {
        public AdvancedRemoteControl(IDevice device) : base(device) { }

        public override void TurnOff()
        {
            Console.WriteLine("Advanced Remote: Turning off the device.");
            device.PowerOff();
        }

        public override void TurnOn()
        {
            Console.WriteLine("Advanced Remote: Turning on the device.");
            device.PowerOn();
        }

        public void SetChannel(int channel)
        {
            Console.WriteLine($"Advanced Remote: Setting channel to {channel}.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityProject
{
    public class LowLevelHandler : ComplaintHandler
    {
        public override void HandleComplaint(string complaint, int severityLevel)
        {
            if (severityLevel <= 1)
            {
                Console.WriteLine($"LowLevelHandler handled the complaint: {complaint}");
            }
            else if (_nextHandler != null)
            {
                _nextHandler.HandleComplaint(complaint, severityLevel);
            }
        }
    }
}

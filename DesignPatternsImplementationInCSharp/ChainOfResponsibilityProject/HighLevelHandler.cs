using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityProject
{
    public class HighLevelHandler : ComplaintHandler
    {
        public override void HandleComplaint(string complaint, int severityLevel)
        {
            if (severityLevel > 3)
            {
                Console.WriteLine($"HighLevelHandler handled the complaint: {complaint}");
            }
        }
    }
}

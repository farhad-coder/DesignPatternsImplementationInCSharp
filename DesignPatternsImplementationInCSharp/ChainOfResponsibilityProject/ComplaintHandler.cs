using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityProject
{
    public abstract class ComplaintHandler
    {
        protected ComplaintHandler _nextHandler;

        public void SetNextHandler(ComplaintHandler nextHandler)
        {
            _nextHandler = nextHandler;
        }

        public abstract void HandleComplaint(string complaint, int severityLevel);
    }
}

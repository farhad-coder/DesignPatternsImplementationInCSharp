using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateProject
{
    public class OnState : IState
    {
        public void Handle(Context context)
        {
            Console.WriteLine("The machine is now ON.");
            context.State = new OffState();
        }
    }
}

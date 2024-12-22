using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace MediatorProject
{
    public interface IChatroomMediator
    {
        void SendMessage(string message, User user);
        void RegisterUser(User user);
    }
}

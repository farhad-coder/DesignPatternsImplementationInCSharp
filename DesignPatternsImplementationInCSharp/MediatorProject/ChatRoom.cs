using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorProject
{
    public class ChatRoom : IChatroomMediator
    {
        private readonly List<User> _users = new List<User>();
        public void RegisterUser(User user)
        {
            _users.Add(user);
        }

        public void SendMessage(string message, User user)
        {
            foreach (var u in _users)
            {
                if (u != user)
                {
                    u.Receive(message);
                }
            }
        }
    }
}

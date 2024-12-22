using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorProject
{
    public class User
    {
        private readonly IChatroomMediator _chatRoom;

        public string Name { get; }

        public User(string name, IChatroomMediator chatRoom)
        {
            Name = name;
            _chatRoom = chatRoom;
        }

        public void Send(string message)
        {
            Console.WriteLine($"{Name} sends: {message}");
            _chatRoom.SendMessage(message, this);
        }

        public void Receive(string message)
        {
            Console.WriteLine($"{Name} receives: {message}");
        }
    }
}

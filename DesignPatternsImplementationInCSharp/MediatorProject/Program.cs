
using MediatorProject;

IChatroomMediator chatRoom = new ChatRoom();

User user1 = new User("Alice", chatRoom);
User user2 = new User("Bob", chatRoom);
User user3 = new User("Charli", chatRoom);

chatRoom.RegisterUser(user1);
chatRoom.RegisterUser(user2);
chatRoom.RegisterUser(user3);

user1.Send("Hello everyone!");
user2.Send("Hi Alice!");
user3.Send("Hey Bob and Alice!");
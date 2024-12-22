
using CommandProject;

Light livingRoomLight = new Light();
Television livingRoomTv = new Television();

ICommand lightOn = new LightOnCommand(livingRoomLight);
ICommand lightOff = new LightOffCommand(livingRoomLight);
ICommand tvOn = new TelevisionOnCommand(livingRoomTv);
ICommand tvOff = new TelevisionOffCommand(livingRoomTv);

RemoteControl remote = new RemoteControl();

remote.Submit(lightOn);
remote.Submit(tvOn);
remote.Undo();
remote.Submit(lightOff);
remote.Undo();
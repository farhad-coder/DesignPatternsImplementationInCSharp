
using BridgeProject;

IDevice tv = new TV();
RemoteControl remoteControl = new AdvancedRemoteControl(tv);

remoteControl.TurnOn();
((AdvancedRemoteControl)remoteControl).SetChannel(5);
remoteControl.TurnOff();

IDevice radio = new Radio();
remoteControl = new AdvancedRemoteControl(radio);

remoteControl.TurnOn();
((AdvancedRemoteControl)remoteControl).SetChannel(101);
remoteControl.TurnOff();
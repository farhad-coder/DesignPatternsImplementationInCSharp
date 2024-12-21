
using AdapterProject;

Adaptee adaptee = new Adaptee();
ITarget adapter = new Adapter(adaptee);

Client client = new Client(adapter);
client.Execute();

using System.Security.AccessControl;
using VisitorProject;

ObjectStructure structure = new ObjectStructure();

structure.Add(new ElementA());
structure.Add(new ElementB());

ConcreteVisitor1 visitor1 = new ConcreteVisitor1();
ConcreteVisitor2 visitor2 = new ConcreteVisitor2();

Console.WriteLine("using ConcreteVisitor1:");
structure.Accept(visitor1);

Console.WriteLine("using ConcreteVisitor2:");
structure.Accept(visitor2);

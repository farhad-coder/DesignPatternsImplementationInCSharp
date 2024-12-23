
using TemplateMethodProject;

Console.WriteLine("Execute algorithm ConcreteClassA:");
AbstractClass classA = new ConcreteClassA();
classA.TemplateMethod();

Console.WriteLine("Execute algorithm ConcreteClassB:");
AbstractClass classB = new ConcreteClassB();
classB.TemplateMethod();
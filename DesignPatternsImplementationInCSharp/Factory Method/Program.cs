
using Factory_Method;

AnimalFactory dogFactory = new DogFactory();
IAnimal dog = dogFactory.CreateAnimal();
dog.Speak();

AnimalFactory catFactory = new CatFactory();
IAnimal cat = catFactory.CreateAnimal();
cat.Speak();
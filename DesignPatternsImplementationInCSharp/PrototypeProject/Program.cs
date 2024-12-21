
using PrototypeProject;

Car originalCar = new Car("Tesla Model S", "Red", 1000);

Car clonedCar = (Car)originalCar.Clone();

Console.WriteLine("Original Car: " + originalCar);
Console.WriteLine("Cloned Car: " + clonedCar);

clonedCar.Color = "Blue";
Console.WriteLine("After modifying the cloned car's color:");

Console.WriteLine("Original Car: " + originalCar);
Console.WriteLine("Cloned Car: " + clonedCar);
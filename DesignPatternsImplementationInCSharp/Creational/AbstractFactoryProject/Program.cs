
using AbstractFactoryProject;

ICarFactory toyotaFactory = new ToyotaFactory();
ICarFactory fordFactory = new FordFactory();

ISedan toyotaSedan = toyotaFactory.CreateSedan();
ISUV toyotaSUV = toyotaFactory.CreateSUV();

ISedan fordSedan = fordFactory.CreateSedan();
ISUV fordSUV = fordFactory.CreateSUV();

toyotaSedan.DisplayDetails();
toyotaSUV.DisplayDetails();
fordSedan.DisplayDetails();
fordSUV.DisplayDetails();
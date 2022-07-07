
using AbstractFactory;

IFurnitureFactory factory = new ModernFurnitureFactory();

var chair = factory.CreateChair();
chair.WhoAreYou();

factory.CreateSofa().WhoAreYou();
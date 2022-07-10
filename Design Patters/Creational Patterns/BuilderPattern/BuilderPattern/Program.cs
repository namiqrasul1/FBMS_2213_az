using BuilderPattern.Builders;
using BuilderPattern.Models;
using System.Text;

IHouseBuilder hb = new WoodHouseBuilder();

House h = hb.BuildWalls(4).BuildDoors(5).BuildRooms(5).BuildGarden().BuildSwimmingPool().GetHouse();
hb.Reset();
Console.WriteLine("Namig's house: ");
Console.WriteLine(h);
Console.WriteLine();
Console.WriteLine("Flower's house");
House woodHouse = hb.BuildRooms(5).BuildDoors(8).BuildWindows(10).BuildGarden().BuildGarrage().BuildSwimmingPool().BuildRoof().GetHouse();

Console.WriteLine(woodHouse);

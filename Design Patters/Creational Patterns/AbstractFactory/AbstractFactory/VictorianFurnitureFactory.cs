using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class VictorianFurnitureFactory : IFurnitureFactory
    {
        public Chair CreateChair() => new VictorianChair();

        public Sofa CreateSofa() => new VictorianSofa();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class ModernFurnitureFactory : IFurnitureFactory
    {
        public Chair CreateChair() => new ModernChair();

        public Sofa CreateSofa() => new ModernSofa();
    }
}

using FactoryMethod.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace FactoryMethod.Concrete
{
    public class Truck : ITransport
    {
        public void Deliver() => WriteLine("Deliver by land");
    }
}

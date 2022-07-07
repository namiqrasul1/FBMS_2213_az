using FactoryMethod.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Concrete
{
    public class Ship : ITransport
    {
        public void Deliver() => Console.WriteLine("Deliver by sea");
    }
}

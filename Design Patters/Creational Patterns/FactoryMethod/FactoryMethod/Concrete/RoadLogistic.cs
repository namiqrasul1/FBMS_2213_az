using FactoryMethod.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Concrete
{
    public class RoadLogistic : Logistic
    {
        public override ITransport CreateTransport() => new Truck();
        public override void PlanDelivery() => Console.WriteLine("RoadLogistic");
    }
}

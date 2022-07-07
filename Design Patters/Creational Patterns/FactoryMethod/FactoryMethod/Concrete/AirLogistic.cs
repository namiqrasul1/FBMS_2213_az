using FactoryMethod.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Concrete
{
    public class AirLogistic : Logistic
    {
        public override ITransport CreateTransport() => new Plane();

        public override void PlanDelivery() => Console.WriteLine("Air Logistic");
    }
}

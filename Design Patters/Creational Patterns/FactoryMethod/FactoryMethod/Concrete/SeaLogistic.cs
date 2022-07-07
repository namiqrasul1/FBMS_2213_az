using FactoryMethod.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Concrete
{
    public class SeaLogistic : Logistic
    {
        public override ITransport CreateTransport() => new Ship();
        public override void PlanDelivery() => Console.WriteLine("SeaLogistic");
    }
}

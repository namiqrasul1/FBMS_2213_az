using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Abstracts
{
    public abstract class Logistic
    {
        //public string State { get; set; }
        public virtual void PlanDelivery() => Console.WriteLine("Logistic");
        public abstract ITransport CreateTransport();
    }
}

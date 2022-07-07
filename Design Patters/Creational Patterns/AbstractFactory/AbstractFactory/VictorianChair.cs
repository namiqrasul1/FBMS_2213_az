using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class VictorianChair : Chair
    {
        public override bool HasLeg() => true;
        public override bool SitOn() => true;
        public override void WhoAreYou() => Console.WriteLine("I am Victorian Chair");
    }
}

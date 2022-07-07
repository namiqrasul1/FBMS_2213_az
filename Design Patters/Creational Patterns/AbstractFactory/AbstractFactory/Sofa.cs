using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public abstract class Sofa 
    {
        public abstract bool HasLeg();
        public abstract bool SitOn();
        public abstract void WhoAreYou();
    }
}

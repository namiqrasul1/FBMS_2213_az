using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class MsSql : Database
    {
        public override void Add()
        {
            Console.WriteLine("Added to MsSql");
        }

        public override void Delete()
        {
            Console.WriteLine("Deleted from MsSql");
        }

    }
}

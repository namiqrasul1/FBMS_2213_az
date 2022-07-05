using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class NoSql : Database
    {
        public override void Add()
        {
            Console.WriteLine("Added to NoSql");
        }

        public override void Delete()
        {
            Console.WriteLine("Deleted from NoSql");
        }

        public override void Update()
        {
            Console.WriteLine("Update at NoSql");
        }
    }
}

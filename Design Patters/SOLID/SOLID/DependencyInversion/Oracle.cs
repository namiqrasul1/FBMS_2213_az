using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Oracle : Database
    {
        public override void Add()
        {
            Console.WriteLine("Added to Oracle");
        }

        public override void Delete()
        {
            Console.WriteLine("Deleted from Oracle");
        }

        public override void Update()
        {
            Console.WriteLine("Update at Oracle");
        }
    }
}

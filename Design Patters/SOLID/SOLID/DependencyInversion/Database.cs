using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Database
    {
        public Database()
        {
            Console.WriteLine("DB Constructor");
        }

        virtual public void Add()
        {
            Console.WriteLine("Added to DB");
        }

        virtual public void Update()
        {
            Console.WriteLine("Update at DB");
        }

        virtual public void Delete()
        {
            Console.WriteLine("Deleted from DB");
        }
    }
}

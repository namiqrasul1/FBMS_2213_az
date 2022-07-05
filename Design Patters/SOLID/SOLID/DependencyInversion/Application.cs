using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Application
    {
        public Database DbContext { get; set; }

        public Application(Database dbContext)
        {
            DbContext = dbContext;
        }

        public void DoSomething()
        {
            DbContext.Add();
            DbContext.Delete();
            DbContext.Update();
        }
    }
}

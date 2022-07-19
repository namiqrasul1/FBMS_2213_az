using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Handlers
{
    public interface IChecker
    {
        public IChecker Next { get; set; }

        public void Check(object request);

    }
}

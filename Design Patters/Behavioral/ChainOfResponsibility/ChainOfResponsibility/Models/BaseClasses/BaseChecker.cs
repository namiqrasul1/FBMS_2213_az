using ChainOfResponsibility.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Models.BaseClasses
{
    public abstract class BaseChecker : IChecker
    {
        public IChecker Next { get; set; }

        public abstract void Check(object request);
    }
}

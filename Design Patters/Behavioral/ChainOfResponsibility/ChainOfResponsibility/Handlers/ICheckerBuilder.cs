using ChainOfResponsibility.Models.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Handlers
{
    public interface ICheckerBuilder
    {
        public BaseChecker EmailChecker { get; set; } 

        public BaseChecker UsernameChecker { get; set; }

        public BaseChecker PasswordChecker { get; set; }
    }
}

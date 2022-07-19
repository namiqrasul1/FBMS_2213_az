using FacadaPattern.Models.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class User : Human
    {

        public User(string username, string email, string password) : base(username, email, password) { }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadaPattern.Models.BaseClasses
{

    public abstract class Human
    {
        public Human(string username,  string email, string password)
        {
            Username = username;
            Email = email;
            Password = password;
        }

        public Human() { }

        public string Username { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
    }
}

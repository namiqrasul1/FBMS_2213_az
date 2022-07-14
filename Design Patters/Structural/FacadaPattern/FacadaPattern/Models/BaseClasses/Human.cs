using FacadaPattern.Models.SubClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadaPattern.Models.BaseClasses
{
    public enum UserProcessResult { Succes,  Fail }

    public abstract class Human
    {
        protected Human(string username, string phone, string email, Hash password)
        {
            Username = username;
            Phone = phone;
            Email = email;
            Password = password;
        }

        public Human() { }

        public string Username { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public Hash Password { get; set; }
    }
}

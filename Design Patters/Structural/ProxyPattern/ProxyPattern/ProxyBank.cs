using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public  class ProxyBank : IBank
    {
        private Bank realObject;

        public string Name { get; set; } = String.Empty;
        public string Password { get; set; } = String.Empty;
        public bool Login { get; set; }

        public ProxyBank(string name,string password)
        {
            Name = name;
            Password = password;
        }


        public bool SignIn()
        {
            if(Name == "Natiq" && Password == "23")
            {
                realObject = new Bank();
                Console.WriteLine("Logged in your account");
                Login = true;
                return true;
            }
            Login = false;
            return false;
        }

        public bool Payment(double amount)
        {
            SignIn();

            if (!Login)
            {
                Console.WriteLine("Don't logged in your account");
                return false;
            }


            realObject.Payment(amount);
            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class Bank : IBank
    {
        public bool Payment(double amount)
        {

            double credit = 500;
            if (amount > credit)
                Console.WriteLine("Your amount more than credit");
            else if (amount < credit)
                Console.WriteLine("Your amount less than credir");
            else
            {
                Console.WriteLine("Your amount equal to credit, Payment Succesfully :)");
                return true;
            }
            return false;    
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadaPattern.Services
{
    public abstract class EmailService
    {
        public static void Send(string text) { Console.WriteLine($"{text} sended"); }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPrototype
{
    public class President
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public double Height { get; set; }
        public string Country { get; set; }
        private static President president { get; set; }

        private President() { }

        public static President GetPresident()
        {
            if (president == null)
                president = new() { Name = "Ilham", Surname = "Aliyev", Height = 1.88, Country = "Dunyanin Hesret Apardigi Azerbaycan!!!!" };
            return president;
        }

        public override string ToString() => $"{Name} {Surname} {Height} {Country}";
    }
}

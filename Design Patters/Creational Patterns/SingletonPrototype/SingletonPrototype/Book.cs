using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPrototype
{

    public class Book : ICloneable
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int PublishYear { get; set; }

        public Book(Book b)
        {
            Name = b.Name;
            Author = b.Author;
            PublishYear = b.PublishYear;


        }

        public Book()
        {
            var p = President.GetPresident();
            p.Country = "Azerbaycan";
        }

        public object Clone() => new Book(this);
    }
}

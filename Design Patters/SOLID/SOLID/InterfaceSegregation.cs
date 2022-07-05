using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class Program
    {
    }

    public abstract class Animal
    {
        public abstract void Feed();
    }

    public abstract class Pet : Animal
    {
        public abstract void Groom();
    }

    public class Wolf : Animal
    {
        public override void Feed()
        {
            Console.WriteLine();
        }

    }

    public class Dog : Pet
    {
        public override void Feed()
        {
            Console.WriteLine();
        }

        public override void Groom()
        {
            Console.WriteLine();
        }
    }
}

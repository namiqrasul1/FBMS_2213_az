using System.Collections;

namespace std
{

    class A : IEnumerable
    {
        public List<int> List { get; set; } = new() { 1, 2, 3, 4, 5 };
        public IEnumerator GetEnumerator()
        {
            return List.GetEnumerator();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var a = new A();
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
        }
    }
}
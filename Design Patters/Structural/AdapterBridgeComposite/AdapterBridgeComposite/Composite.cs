using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compositee
{
    public interface ISystemItem // component
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public double Size { get; }
    }

    public class File : ISystemItem // leaf
    {
        public File(string name, string path, double size)
        {
            Name = name;
            Path = path;
            Size = size;
        }

        public string Name { get; set; }
        public string Path { get; set; }
        public double Size { get; }
    }


    public class Folder : ISystemItem // composite
    {
        public List<ISystemItem> Items { get; set; } = new();

        public Folder(string name, string path)
        {
            Name = name;
            Path = path;
        }

        public string Name { get; set; }
        public string Path { get; set; }
        public double Size
        {
            get
            {
                double size = 0;
                Items.ForEach(i => size += i.Size);
                return size;
            }
        }
        // Folder => (Folder =>(1, 2, 2), (Folder => file)), File
        public void Add(ISystemItem item) { Items.Add(item); }

        public void Remove(ISystemItem item) { Items.Remove(item); }

    }

    public class Composite
    {
        static void Main(string[] args)
        {
            Folder folder = new("C", "C:");
            Folder folder1 = new("newFolder", "C:/");
            Folder folder2 = new("newFolder1", "C:/newFolder");
            folder2.Items.Add(new File("a", "C:/newFolder/newFolder1", 1));
            folder2.Items.Add(new File("a", "C:/newFolder/newFolder1", 3));
            folder1.Items.Add(new File("a", "C:/newFolder", 4));
            folder1.Items.Add(folder2);

            folder.Items.Add(folder1);
            folder.Items.Add(new File("a", "C:", 2));
            folder.Items.Add(new File("a", "C:", 5));
            folder.Items.Add(new File("a", "C:", 6));
            Console.WriteLine(folder.Size);

        }
    }
}

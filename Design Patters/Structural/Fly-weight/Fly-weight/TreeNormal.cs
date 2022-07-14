using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fly_weight
{
    public class TreeNormal
    {
        public TreeNormal(int x, int y, string name, string color, string texture)
        {
            X = x;
            Y = y;
            Name = name;
            Color = color;
            Texture = texture;
        }

        public int X { get; set; }
        public int Y { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string Texture { get; set; }
    }
}

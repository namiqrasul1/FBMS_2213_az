using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fly_weight
{
    public class Tree
    {
        public Tree(int x, int y, string name, string color, string texture)
        {
            X = x;
            Y = y;
            TreeType = TreeFactory.GetTreeType(name, color, texture);
        }

        public int X { get; set; }
        public int Y { get; set; }
        public TreeType TreeType { get; set; }


      
    }
}

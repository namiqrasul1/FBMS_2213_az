using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fly_weight
{
    public class TreeFactory
    {
        private static List<TreeType> TreeTypes = new();

        public static TreeType GetTreeType(string name, string color, string texture)
        {
            var type = TreeTypes.FirstOrDefault(t => t.Name == name && t.Color == color && t.Texture == texture);
            if (type == null)
            {
                type = new TreeType(name, color, texture);
                TreeTypes.Add(type);
            }
            return type;
        }
    }
}

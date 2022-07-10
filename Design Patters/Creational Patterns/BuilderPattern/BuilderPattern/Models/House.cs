using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Models
{
    public class House
    {
        public string Name { get; set; }
        public int Walls { get; set; }
        public int Windows { get; set; }
        public int Doors { get; set; }
        public int Rooms { get; set; }
        public bool HasGarrage { get; set; }
        public bool HasRoof { get; set; }
        public bool HasGarden { get; set; }
        public bool HasSwimmingPool { get; set; }

        public override string ToString() =>
@$"Name: {Name}
Walls: {Walls} 
Windows: {Windows} 
Doors: {Doors} 
Rooms: {Rooms} 
Garden: {HasGarden} 
SP: {HasSwimmingPool}
Roof: {HasRoof}
Garrage: {HasGarrage}";
    }
}

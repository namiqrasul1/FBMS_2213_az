using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadaPattern.Models.SubClasses
{
    public class Hash
    {
        public Hash(string value)
        {
            Value = value;
        }

        public string Value { get; set; }
    }
}

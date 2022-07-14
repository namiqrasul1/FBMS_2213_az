using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Renderer : AbstractRenderer
    {
        public override void RenderInformation(string info) => Console.WriteLine(info);
      
    }
}

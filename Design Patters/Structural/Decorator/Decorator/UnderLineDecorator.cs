using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class UnderLineDecorator : AbstractRenderer
    {
        private AbstractRenderer renderer;

        public UnderLineDecorator(AbstractRenderer renderer)
        {
            this.renderer = renderer;
        }

        public override void RenderInformation(string info)
        {
            renderer.RenderInformation(info);
            foreach (var item in info)
            {
                Console.Write("_");
            }
            Console.WriteLine();
        }
    }
}

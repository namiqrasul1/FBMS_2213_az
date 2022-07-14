using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class ColorDecorator : AbstractRenderer
    {
        private AbstractRenderer renderer;
        private ConsoleColor color;

        public ColorDecorator(AbstractRenderer renderer, ConsoleColor color)
        {
            this.renderer = renderer;
            this.color = color;
        }

        public override void RenderInformation(string info)
        {
            var oldColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            renderer.RenderInformation(info);
            Console.ForegroundColor = oldColor;
        }
    }
}

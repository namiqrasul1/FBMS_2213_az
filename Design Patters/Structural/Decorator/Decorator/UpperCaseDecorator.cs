using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class UpperCaseDecorator : AbstractRenderer
    {
        private AbstractRenderer renderer;

        public UpperCaseDecorator(AbstractRenderer renderer)
        {
            this.renderer = renderer;
        }

        public override void RenderInformation(string info)
        {
            renderer.RenderInformation(info.ToUpper());
        }

    }
}

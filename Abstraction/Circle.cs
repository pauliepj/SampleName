using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Circle : Figure
    {
        public Circle(double r)
        {
            this.radius = r;
        }
        public override double GetArea()
        {
            return (radius * 2 * pi);
        }
    }
}

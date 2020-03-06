using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Cone : Figure
    {
        public Cone(double r, double sl)
        {
            this.radius = r;
            this.slant = sl;
        }
        public override double GetArea()
        {
            return (3.14 * radius * slant) +(3.14 * radius * radius);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Triangle : Figure
    {
        public Triangle(double w, double h)
        {
            this.width = w;
            this.height = h;
        }
        public Triangle (double w, double h,double r)
        {
            this.width = w;
            this.height = h;
            this.radius = r;
          
        }

        public override double GetArea()
        {
            return (.5 * width * height);  
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Rectangle : Figure //abstract methods must also be inside the child class
    {
        
        public Rectangle(double w, double h)
        {
            this.width = w;
            this.height = h;
        }
        public override double GetArea() // only the child class can use the override function
        {
            return width * height;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a value for radius");
            double v1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a value for width/base");
            double v2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a value for height");
            double v3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a value for slant");
            double v4 = Convert.ToInt32(Console.ReadLine());
            Triangle T1 = new Triangle(v2, v3);
            double a1 = T1.GetArea();
            Console.WriteLine("The triangle's area is " + a1);
            Console.ReadLine();
            Circle C1 = new Circle(v1);
            //test
            double a2 = C1.GetArea();
            Console.WriteLine("The area of the circle is " + a2);
            Console.ReadLine();
            Rectangle R1 = new Rectangle(v2, v3);
            double a3 = R1.GetArea();
            Console.WriteLine("The area of the rectangle is " + a3);
            Console.ReadLine();
            Cone C2 = new Cone(v1, v4);
            double a4 = C2.GetArea();
            Console.WriteLine("The surface area of the cone is " + a4);
            Console.ReadLine();
        }
    }
}

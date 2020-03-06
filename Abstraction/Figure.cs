using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{   //a method without any method body is known as an abstract method
    //a class that contains any abstract members in it is called an abstract class
    //abstract classes cannot be instantiated.
    //when you inherit from an abstract class, the child class must also use the 
    //abstract members of the parent abstract class
    public abstract class Figure
    {
        public double width, height, radius, slant;
        public float pi = 3.14f;
        
        //abstract method
        public abstract double GetArea();
    }
}

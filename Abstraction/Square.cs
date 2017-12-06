using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Square : Shape //MUST implement the methods in Shape
    {
        public double Length { get; set; }
        public Square(string name, double length) : base(name) //referencing the base classes constructor
        {
            Length = length;
        }


        public override double Area()
        {
            return Length * Length;
        }

    }
}

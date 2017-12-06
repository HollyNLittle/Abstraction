using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    //INTERFACE: contract, can't have subclasses, can't have body, ALL public, MUST use All members, NO constructors
    //
    class Circle : IShape //IMPLEMENTS Interface; MUST implement anything in the interface
    {
        public string Name { get; set; }
        public double Radius { get; set; }
        static  int circleNumber;

        public int CircleNumber
        {
            get { return circleNumber; }
        }
        public Circle(string name, double radius)
        {
            Name = name;
            Radius = radius;
            circleNumber += 1;
        }
        public double Area()
        {
            double pi = Math.PI;
            return pi * Math.Pow(Radius, 2); //POWER METHOD X TO THE 2ND POWER
        }

        public void GetInfo()
        {
            Console.WriteLine("Iam a " + Name);
        }

        public void NumberOfCircles()
        {
            Console.WriteLine("The number of circles is ", 10);
        }
    }
}

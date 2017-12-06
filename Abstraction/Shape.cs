using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    abstract class Shape
    {   //anytime a field is specific to or is not ???????
        public string Name { get; set; }//shorthand, creates a field in the background, because you didnt create one

        abstract public double Area();//abstract methods can't have a body
        public Shape(string name)
        {
            Name = name;
        }

        public void GetInfo()
        {
            Console.WriteLine("i am a {0}", Name);
        }

    }
}

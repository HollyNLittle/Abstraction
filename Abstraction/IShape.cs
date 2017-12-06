using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    interface IShape//Abstract: can have body code, 
        //MUST implement ABSTRACT members, can have constructors, 
        //can't be sealed, can't create an instanceOf, should ONLY be a BASE class
    {
        //any property created in interface has to be implemented so 

        void GetInfo();
        double Area();
        
    }
}

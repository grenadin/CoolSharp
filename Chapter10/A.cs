using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter10
{
    class A
    {

        public A()
        {
             B b = new B();
        }
       
        public void Say()
        {
            Console.WriteLine("Hi A");
        }

        
        
    }
}

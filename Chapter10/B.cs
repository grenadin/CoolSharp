using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter10
{
    class B
    {
        public B()
        {
            A a = new A();
        }

        public void Say()
        {
            Console.WriteLine("Hi B");
        }
    }
}

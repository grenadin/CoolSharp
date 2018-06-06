using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter10
{
    class Derived:Base
    {
        public override string Meth1() //inherit from base class
        {
            return "MyDerived-Meth1";
        }

        public new string Meth2()// hiding base class
        {
            return "MyDerived-Meth2";
        }

        public string Meth3()
        {
            return "MyDerived-Meth3";
        }

        public string Meth4()
        {
            return "MyDerived-Meth4";
        }


        public override int Foo()
        {
            Console.WriteLine("yeah");
            return 6;
        }


        public Derived()
        {
            Console.WriteLine("hi from derived");
        }
    }
}

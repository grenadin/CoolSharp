using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter10
{
    class Derived:Base
    {
        public override string Meth1()
        {
            return "MyDerived-Meth1";
        }

        public new string Meth2()
        {
            return "MyDerived-Meth2";
        }

        public string Meth3()
        {
            return "MyDerived-Meth3";
        }

    }
}

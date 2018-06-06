using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter10
{
    class Base
    {
        public virtual string Meth1() // Set for derived class 
        {
            return "MyBase-Meth1";
        }

        public virtual string Meth2()
        {
            return "MyBase-Meth2";
        }

        public virtual string Meth3()
        {
            return "MyBase-Meth3";
        }

        public string Meth4()
        {
            return "MyBase-Meth4";
        }

       

        public int a = 6;

        public Base()
        {
            Console.WriteLine("hi");
        }

        protected void Method1()
        {
            Console.WriteLine("Method1");
        }
        

    }
}

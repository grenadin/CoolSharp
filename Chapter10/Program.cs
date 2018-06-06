using System;

namespace Chapter10
{
    class Program
    {
        static void Main(string[] args)
        {
            Base myBase = new Base();
            Derived myDerived = new Derived();

            Base myTest = new Derived();

            Console.WriteLine(myBase.Meth1());
            Console.WriteLine(myBase.Meth2());
            Console.WriteLine(myBase.Meth3());
            Console.WriteLine(myBase.Meth4());

            Console.WriteLine(myDerived.Meth1());
            Console.WriteLine(myDerived.Meth2()); 
            Console.WriteLine(myDerived.Meth3());
            Console.WriteLine(myDerived.Meth4());


            Console.WriteLine(myTest.Meth1());
            Console.WriteLine(myTest.Meth2());
            Console.WriteLine(myTest.Meth3());
            Console.WriteLine(myTest.Meth4());

            





        }
    }
}

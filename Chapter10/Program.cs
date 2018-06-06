using System;

namespace Chapter10
{
    class Program
    {
        static void Main(string[] args)
        {
            #region base derived
            //Base myBase = new Base();


            //Derived myDerived = new Derived();


            //Base myTest = new Derived();

            //Console.WriteLine($"{myBase.Meth1()} call Meth1() from Base Class" );
            //Console.WriteLine($"{myBase.Meth2()} call Meth2() from Base Class");
            //Console.WriteLine($"{myBase.Meth3()} call Meth3() from Base Class");
            //Console.WriteLine($"{myBase.Meth4()} call Meth4() from Base Class");
            //Console.WriteLine("----------------------------------------------------------------------------");
            //Console.WriteLine($"{myDerived.Meth1()} call Meth1() from Derived Class");
            //Console.WriteLine($"{myDerived.Meth2()} call Meth2() from Derived Class but hide Base Function"); 
            //Console.WriteLine($"{myDerived.Meth3()} call Meth3() from Derived Class don't use new keyword");
            //Console.WriteLine($"{myDerived.Meth4()} call Meth3() from Derived Class don't use new keyword");
            //Console.WriteLine("----------------------------------------------------------------------------");
            //Console.WriteLine($"{myTest.Meth1()} call Meth1() but call from Derived ");
            //Console.WriteLine($"{myTest.Meth2()} call Meth2() but call from Base ");
            //Console.WriteLine($"{myTest.Meth3()} call Meth3() but call from Base");
            //Console.WriteLine($"{myTest.Meth4()} call Meth4() but call from Base");


            //myDerived.t();
            #endregion

            Animal MyPet = new StBernard();
            MyPet.Say();

            MyPet = new Dog();

            MyPet.Say();

            MyPet.Age = 5;

            Console.WriteLine(MyPet.Age);
            
            

        }
    }
}

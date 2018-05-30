using System;

namespace Chapter08
{
    class Program
    {
        static void Main(string[] args)
        {
            TestObject x = new TestObject();
            x.Data = 50;
            Console.WriteLine(x.Data);
            Console.ReadLine();
            

            //beware for the confuse the name of Testobject.cs in ch07 and ch08


        }
    }
}

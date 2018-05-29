using System;

namespace Chapter08
{
    class Program
    {
        static void Main(string[] args)
        {
            NokiaPhone myMobile = new NokiaPhone("8250", "Silver", true);
            NokiaPhone youMobile = new NokiaPhone("6500", "Silver");

            Console.WriteLine(myMobile.getModel());
            Console.WriteLine(myMobile.changeAble());

            Console.WriteLine(youMobile.getModel());
            Console.WriteLine(youMobile.changeAble());
            Console.WriteLine();
           
            

            Console.ReadLine();
        }
    }
}

using System;

namespace Chapter09
{
    class Program
    {
        static void Main(string[] args)
        {
            //Num a = new Num(7);
            //Num b = new Num(5);
            //Num c = new Num();
            //c.Data = Num.FindMax(a,b).Data;
            //Console.WriteLine(c.Data);

            //Console.ReadLine();

            //Console.WriteLine(Num.FindMax(new Num(7), new Num(5)).Data);

            //Console.WriteLine( (new Num(7).Data * new Num(5).Data) );

            Num a = new Num(29);
            Num b = new Num(72);
            Num c = a + b;
            a++;
            int x;
            x = 5;

            x++;
            Console.WriteLine(x);
            Console.WriteLine(a.Data);
            Console.ReadLine();
           
        }
    }
}

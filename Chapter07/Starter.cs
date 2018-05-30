using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter07
{
    class Starter
    {
        static void Main()
        {
            Person me = new Person();
            me.name = "Visavachit";
            me.surname = "Suriyachant";
            me.age = 25;
            me.nationality = "Thai";

            me.Walk();
            me.Run();
            me.Talk("Hello");
            Console.ReadLine();
        }
    }        
}
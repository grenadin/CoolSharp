using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter10
{
    class Dog:Animal,ISwimmable
    {
        public override void Say() { Console.WriteLine("box box"); }
        void ISwimmable.Swim() => Console.WriteLine($"Dog swim");
       

       

       
       
    }
}

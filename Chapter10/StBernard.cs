using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter10
{
    class StBernard:Dog,ISwimmable
    {
       

        public override void Say() { Console.WriteLine("I'm StBernard"); }
        void ISwimmable.Swim() => Console.WriteLine($"STB swim");
    }
}

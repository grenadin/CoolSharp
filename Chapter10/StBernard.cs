using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter10
{
    class StBernard:Dog,ISwimmable,IFlyable
    {
        public void fly() => throw new NotImplementedException();

        public override void Say() { Console.WriteLine("I'm StBernard"); }
        void ISwimmable.Swim() => Console.WriteLine($"STB swim");
    }
}

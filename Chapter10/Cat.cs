using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter10
{
    class Cat : Animal
    {
        public override void Say() => Console.WriteLine("meow meow");
        //void ISwimmable.Swim() => Console.WriteLine($"Cat swim");

    }
}

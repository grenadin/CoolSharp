using System;

namespace Chapter10
{
    internal class PersianCat : Cat,ISwimmable
    {
        public override void Say() => Console.WriteLine("I'm persian");
        void ISwimmable.Swim() => Console.WriteLine($"Persia swim");
    }
}
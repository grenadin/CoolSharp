using System;
namespace Chapter10
{
    internal class ChowChow : Dog,ISwimmable
    {

        void ISwimmable.Swim() => Console.WriteLine($"Ch swim");

    }
}
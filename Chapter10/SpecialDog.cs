using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter10
{
    class SpecialDog : StBernard
    {
        public SpecialDog()
        {
        }

        public override void Say()
        {
            Console.WriteLine("Spec Dog");
        }
    }
}

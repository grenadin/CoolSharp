using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter10
{
    class DogHouse
    {
        public void Welcome(dynamic d)
        {
            d.Say();
            if(d is ISwimmable)
            ((ISwimmable)d).Swim();
            else
                Console.WriteLine("this animal can not swim");
        }

        //public void Welcome(Cat c)
        //{
        //    c.Say(); 
        //}

        //public void Welcome(ISwimmable s)
        //{
        //    s.Swim();

        //}
    }
}

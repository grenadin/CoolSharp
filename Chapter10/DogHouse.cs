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
            ((ISwimmable)d).Swim();
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

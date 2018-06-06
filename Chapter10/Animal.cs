using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter10
{
     abstract class Animal
    {
        abstract public void Say();

        public int Age { get; set; }

        public int getAge()
        {
            return Age;
        }

        //abstract public void ShowAge();
        
        
    }
}

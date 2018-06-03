using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter08
{
    class ObjectInitializer
    {
        int age;

        public string Name { get; set; }
        public int Age { get => age; set => age = value; }
    }
}

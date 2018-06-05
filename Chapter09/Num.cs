using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter09
{
    class Num
    {
        int data;


        public Num()
        {

        }
        public Num(int data)
        {
            this.data = data;
            
        }

        public int Data { get => data; set => data = value; }


        public static Num FindMax(Num x, Num y)
        {
            if (x.Data > y.Data)
                
                return x;
            else
                return y;
        }

    }

  
}

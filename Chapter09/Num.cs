using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter09
{
    class Num
    {
        public Num()
        {

        }
        public Num(int data)
        {
            this.Data = data;
            
        }

        public int Data { get; set; }  


        public static Num FindMax(Num x, Num y)
        {
            if (x.Data > y.Data)
                
                return x;
            else
                return y;
        }

        public static Num operator +(Num x,  Num y)
        {
            return new Num(x.Data + y.Data);
        }

        public static Num operator ++(Num x)
        {
            return new Num(x.Data + 1);
        }

    }

  
}

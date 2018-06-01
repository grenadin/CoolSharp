using System;

namespace Chapter08
{
    class Program
    {
        static void Main(string[] args)
        {
            NokiaPhone myMobile = new NokiaPhone("8250", "silver", true);
            myMobile.Mask = "gold";
            NokiaPhone yourMobile = new NokiaPhone("8800", "red");
            yourMobile.Mask = "gold";
            

           


        }
    }
}

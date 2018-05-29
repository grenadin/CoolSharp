using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter08
{
    class Toilet
    {
        public void Close()
        {
            Console.WriteLine("Close lid");
        }

        public void Open()
        {
            Console.WriteLine("Open lid");
        }

        public void Flush()
        {
            Console.WriteLine("Flush");
            Fill();
            
        }

        void Fill()
        {
            Console.WriteLine("input water");
        }
    }
}

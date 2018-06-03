using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter08
{
    class Toilet
    {
        bool waterSave;
        int total;
        

        public int Total { get => total; set => total = value; }
        public static int UnitPrice { get; set; }

        public Toilet(bool waterSave)
        {
            Total = 0;
            this.waterSave = waterSave;
        }

        public void Close()
        {
            Console.WriteLine($"Close Lid");
        }

        public void Open()
        {
            Console.WriteLine($"Open Lid");
        }

        public void Flush()
        {
            Console.WriteLine("flush...");

            if (waterSave)
            {
                Calculate(5);
            }
            else
                Calculate(10);

            Fill();
        }

        public static void Fill()
        {
            Console.WriteLine("input water");
            
        }


        void Calculate(int n)
        {
            Total += n;
            Console.WriteLine($"The current Price {Total*UnitPrice} baht");
        }

    }
}

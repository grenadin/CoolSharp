using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter10
{
    class iPod
    {
        bool isPlaying = false;
        public void Play() { Console.WriteLine("Play song..."); }

        public void ShowMenu()
        {
            Console.WriteLine($"Show Menu mother");
            Console.WriteLine($"Add new code");
        }
        
       

    }
}

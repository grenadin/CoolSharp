using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter10
{
    class iPodTouch : iPod
    {
       public void ShowCoverFlowMenu()
       { 
            Console.WriteLine($"Show Cover Flow Menu");
       }

        public  void ShowMenu()
        {
            ShowCoverFlowMenu();
        }

        public  void ShowMenu(bool showCoverFlow)
        {
            if (showCoverFlow == true)
                base.ShowMenu();
            else
                this.ShowMenu();
        }



    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter08
{
    class NokiaPhone
    {
        private string model;
        private string mask;
        private bool maskChangeable;

        public NokiaPhone(string model, string mask)
        {
            this.model = model;
            this.mask = mask; // beware this!! when call propertie it take action automatically
            this.maskChangeable = false;
        }

        public NokiaPhone(string model, string mask, bool maskChangeable)
        {
            this.model = model;
            this.mask = mask; // beware this!! when call propertie it take action automatically
            this.maskChangeable = maskChangeable;
        }

        public string Mask
        {
            get => mask;
            set
            {
                if(maskChangeable)
                {
                    mask = value;
                    Console.WriteLine($"This {model} can change mask to {mask}");
                }
                else
                    Console.WriteLine($"This {model} can not change mask");
               
            }
        }
    }
}

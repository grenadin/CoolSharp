using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter08
{
    class NokiaPhone
    {
        string model;
        string mask;
        bool maskChangeable;
        string IMEI;

        public NokiaPhone(string model, string mask)
        {
            this.model = model;
            this.mask = mask;
           
        }

        public NokiaPhone(string model, string mask, bool maskChangeable)
        {
            this.model = model;
            this.mask = mask;
            this.maskChangeable = maskChangeable;
          
        }

        public void changeMask(string mask)
        {
            if (maskChangeable)
            {
                this.mask = mask;
                Console.WriteLine($"{ this.model} Change to color { this.mask}");
            }
            else
            {
                Console.WriteLine($"Sorry this {this.model} model can not changemask");
            }
        }

        public string getModel()
        {
            return model;
        }

        public bool changeAble()
        {
            return maskChangeable;
        }
    }
}

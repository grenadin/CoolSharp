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

        public string Model { get => model; set => model = value; }
        public string Mask { get => mask; set => mask = value; }
        public bool MaskChangeable { get => maskChangeable; set => maskChangeable = value; }

    }
}

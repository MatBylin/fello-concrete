using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FelloConcrete
{
    class ConcreteProps
    {
        public double Fck { get; private set; }
        public double Fctm { get; private set; }
        public double Ecm { get; private set; }

        public ConcreteProps(string nazwaBet)
        {
            if (nazwaBet.ToLower() == "c12/15")
            {
                Fck = 12;
                Fctm = 1.6;
                Ecm = 27;
            }
            else if (nazwaBet.ToLower() == "c16/20")
            {
                Fck = 16;
                Fctm = 1.9;
                Ecm = 29;
            }
            else if (nazwaBet.ToLower() == "c20/25")
            {
                Fck = 20;
                Fctm = 2.2;
                Ecm = 30;
            }
            else if (nazwaBet.ToLower() == "c25/30")
            {
                Fck = 25;
                Fctm = 2.6;
                Ecm = 31f;
            }
            else if (nazwaBet.ToLower() == "c30/37")
            {
                Fck = 30;
                Fctm = 2.9;
                Ecm = 33;
            }
            else if (nazwaBet.ToLower() == "c35/45")
            {
                Fck = 35;
                Fctm = 3.2;
                Ecm = 34;
            }
        }
    }
}

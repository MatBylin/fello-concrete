using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FelloConcrete
{
    class Concrete
    {
        public double fck { get; private set; }
        public double fctm { get; private set; }
        public double ecm { get; private set; }

        public Concrete(string nazwaBet)
        {
            if (nazwaBet.ToLower() == "c12/15")
            {
                fck = 12;
                fctm = 1.6;
                ecm = 27;
            }
            else if (nazwaBet.ToLower() == "C16/20")
            {
                fck = 16;
                fctm = 1.9;
                ecm = 29;
            }
            else if (nazwaBet.ToLower() == "c20/25")
            {
                fck = 20;
                fctm = 2.2;
                ecm = 30;
            }
            else if (nazwaBet.ToLower() == "c25/30")
            {
                fck = 25;
                fctm = 2.6;
                ecm = 31;
            }
            else if (nazwaBet.ToLower() == "c30/37")
            {
                fck = 30;
                fctm = 2.9;
                ecm = 33;
            }
            else if (nazwaBet.ToLower() == "c35/45")
            {
                fck = 35;
                fctm = 3.2;
                ecm = 34;
            }
        }
    }
}

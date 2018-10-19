using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FelloConcrete
{
    class Concrete
    {
        public float fck { get; private set; }
        public float fctm { get; private set; }
        public float ecm { get; private set; }

        public Concrete(string nazwaBet)
        {
            if (nazwaBet.ToLower() == "c12/15")
            {
                fck = 12;
                fctm = 1.6f;
                ecm = 27;
            }
            else if (nazwaBet.ToLower() == "C16/20")
            {
                fck = 16;
                fctm = 1.9f;
                ecm = 29;
            }
            else if (nazwaBet.ToLower() == "c20/25")
            {
                fck = 20;
                fctm = 2.2f;
                ecm = 30;
            }
            else if (nazwaBet.ToLower() == "c25/30")
            {
                fck = 25;
                fctm = 2.6f;
                ecm = 31f;
            }
            else if (nazwaBet.ToLower() == "c30/37")
            {
                fck = 30;
                fctm = 2.9f;
                ecm = 33;
            }
            else if (nazwaBet.ToLower() == "c35/45")
            {
                fck = 35;
                fctm = 3.2f;
                ecm = 34;
            }
        }

        public double AsminBending(double fyk, double fctm, double d, double b)
        {
            double _as1min = (fctm / fyk) * 0.026 * b * d * 0.1;
            double _as2min = (0.0013 * b * d) / 100;
            double _asmin =  Math.Max(_as1min, _as2min);
            return _as2min;
        }
    }
}

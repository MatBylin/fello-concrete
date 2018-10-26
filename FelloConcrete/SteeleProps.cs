using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FelloConcrete
{
    class SteeleProps
    {
        public float Fyk { get; private set; }

        public SteeleProps(string nazwaStal)
        {
            if (nazwaStal.ToLower() == "b400")
            {
                Fyk = 400;
            }
            if (nazwaStal.ToLower() == "b500")
            {
                Fyk = 500;
            }
        }
    }
}

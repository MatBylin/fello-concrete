using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FelloConcrete
{
    class Steele
    {
        public float fyk { get; private set; }

        public Steele(string nazwaStal)
        {
            if (nazwaStal.ToLower() == "b400")
            {
                fyk = 500;
            }
            if (nazwaStal.ToLower() == "b500")
            {
                fyk = 400;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FelloConcrete
{
    class SteeleProps
    {
        string _name;
        double _fyk;

        public SteeleProps(string steeleName)
        {
            _name = steeleName;
        }

        public SteeleOutput StleelePropResult()
        {
            if (_name.ToLower() == "b400")
            {
                _fyk = 400;
            }
            if (_name.ToLower() == "b500")
            {
                _fyk = 500;
            }

            SteeleOutput result = new SteeleOutput
            {
                Fyk = _fyk,
            };

            return result;
        }
    }

    class SteeleOutput
    {
        public double Fyk { get; set; }
    }
}

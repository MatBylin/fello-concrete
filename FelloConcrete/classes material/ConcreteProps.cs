using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FelloConcrete
{
    class ConcreteProps
    {
        double _fck, _fctm, _ecm;
        string _name;

        public ConcreteProps(string concreteName)
        {
            _name = concreteName;
        }

        public ConcreteOutput ConcretePropResult()
        {
            if (_name.ToLower() == "c12/15")
            {
                _fck = 12;
                _fctm = 1.6;
                _ecm = 27;
            }
            else if (_name.ToLower() == "c16/20")
            {
                _fck = 16;
                _fctm = 1.9;
                _ecm = 29;
            }
            else if (_name.ToLower() == "c20/25")
            {
                _fck = 20;
                _fctm = 2.2;
                _ecm = 30;
            }
            else if (_name.ToLower() == "c25/30")
            {
                _fck = 25;
                _fctm = 2.6;
                _ecm = 31f;
            }
            else if (_name.ToLower() == "c30/37")
            {
                _fck = 30;
                _fctm = 2.9;
                _ecm = 33;
            }
            else if (_name.ToLower() == "c35/45")
            {
                _fck = 35;
                _fctm = 3.2;
                _ecm = 34;
            }

            ConcreteOutput result = new ConcreteOutput
            {
                Fck = _fck,
                Fctm = _fctm,
                Ecm = _ecm
            };

            return result;
        }
    }

    class ConcreteOutput
    {
        public double Fck { get; set; }
        public double Fctm { get; set; }
        public double Ecm { get; set; }
    }
}

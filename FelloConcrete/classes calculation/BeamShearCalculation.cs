using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FelloConcrete.classes_calculation
{
    class BeamShearCalculation
    {
        double k, crdc, z, v, tgt, romin, k1, gammaC, vMin, vRdc, sRozstaw, sRozstawFloor;
        double vRds, vRdmax, roStrzemion;
        double pom1, pom2;
        public void Calculate(double d, double b, double fck, double n, double powAs, double fyd, double pow, double as1, double vEd, double ctgt = 1)
        {
            gammaC = 1.4;
            crdc = 0.18 / gammaC;
            z = 0.9 * d;
            tgt = 1;
            k = Math.Min((Math.Sqrt(200 / d)), 2);
            romin = Math.Min(0.02, (as1 / b * d * 0.01));
            k1 = 0.15;
            v = 0.6 - (fck / 250);

            vMin = 0.035 * (Math.Sqrt(k * k * k * fck));
            pom1 = 100 * romin * fck;
            pom2 = Math.Pow(pom1, 0.333);
            //vRdc1 = crdc * k * pom2 * b * d * 0.001;
            //vRdcmin = vMin * b * d * 0.001;
            vRdc = Math.Round(Math.Max((crdc * k * pom2 * b * d * 0.001), (vMin * b * d * 0.001)), 2);

            sRozstaw = Math.Round((n * powAs * fyd * z * 0.01 * ctgt) / (vEd), 2);
            sRozstawFloor = Math.Floor(sRozstaw);

            vRds = Math.Round((n * powAs * fyd * z * 0.01 * ctgt) / (sRozstawFloor));
            vRdmax = Math.Round((b * v * (fck / gammaC) * z * 0.001) / (ctgt + tgt), 2);
            //roStrzemion = 
            
        }
    }
}

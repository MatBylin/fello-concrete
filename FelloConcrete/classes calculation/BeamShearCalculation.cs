using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FelloConcrete
{
    class BeamShearCalculation
    {
        double k, crdc, z, v, tgt, romin, gammaC, gammaS, vMin, vRdc, sRozstaw, sRozstawFloor;
        double vRds, vRdmax, roStrzemion, roMin;
        double pom1, pom2;

        public BeamShearResults Calculate(double d, double b, double fck, double n, double powAs, double fyd, double pow, double as1, double vEd, double ctgt = 1)
        {
            gammaC = 1.4;
            gammaS = 1.15;
            crdc = 0.18 / gammaC;
            z = 0.9 * d;
            tgt = 1;
            k = Math.Min((1 + (Math.Sqrt(200 / d))), 2);
            romin = Math.Min(0.02, (as1 / (b * d * 0.01)));
            v = 0.6 - (fck / 250);

            vMin = 0.035 * (Math.Sqrt(k * k * k * fck));
            pom1 = 100 * romin * fck;
            pom2 = Math.Pow(pom1, 0.333);
            //vRdc1 = crdc * k * pom2 * b * d * 0.001;
            //vRdcmin = vMin * b * d * 0.001;
            vRdc = Math.Max((crdc * k * pom2 * b * d * 0.001), (vMin * b * d * 0.001));
            vRdc = Math.Round(vRdc, 2);

            sRozstaw = Math.Round((n * powAs * fyd * z * 0.01 * ctgt) / (vEd), 2);
            sRozstawFloor = Math.Floor(sRozstaw);

            vRds = Math.Round(((n * powAs * fyd * z * 0.01 * ctgt) / (sRozstawFloor)),2);
            vRdmax = Math.Round((b * v * (fck / gammaC) * z * 0.001) / (ctgt + tgt), 2);
            roStrzemion = Math.Round((n * powAs) / (sRozstawFloor * b * 0.01), 3);
            roMin = Math.Round(0.08 * ((Math.Pow(fck, 0.5)) / (fyd * gammaS)), 3);

            BeamShearResults result = new BeamShearResults
            {
                VRdc = vRdc,
                VRds = vRds,
                VRdmax = vRdmax,
                RoStrzemion = roStrzemion,
                RoMin = roMin,
                RozstawFloor = sRozstawFloor,
            };

            return result;
        }
    }
}

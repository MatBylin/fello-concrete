using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FelloConcrete
{
    class BeamBendCalculation
    {
        double ks, ni, x, y, zasiegStrefySciskanej, zasiegStrefySciskanejLim, ramieSil, mRd, As1, As2;
        const double pi = 3.1415;
        //double Asmin, Asmax;

        public BeamBendResults Calculate(double my, double b, double d, double a, double n, double fcd, double fyd)
        {
            ks = 0.000001 * b * d * d * fcd;
            ni = my / ks;
            x = 1 - 2 * ni;
            y = Math.Sqrt(x);
            zasiegStrefySciskanej = 1 - y;
            zasiegStrefySciskanejLim = 0.493;

            if (zasiegStrefySciskanej < zasiegStrefySciskanejLim)
            {
                ramieSil = (1 - 0.5 * zasiegStrefySciskanej) * d;
                As1 = 10000 * my / (ramieSil * fyd);
                As2 = 0;
            }
            else
            {
                mRd = 0.3715 * b * d * d * fcd * n * 0.000001;
                As2 = (my - mRd) / ((d - a) * fyd) * (10000);
                As1 = ((mRd) / (0.7535 * d * fyd)) * 10000 + As2;
            }

            ni = Math.Round(ni, 3);
            zasiegStrefySciskanej = Math.Round(zasiegStrefySciskanej, 3);
            As1 = Math.Round(As1, 2);
            As2 = Math.Round(As2, 2);


            BeamBendResults result = new BeamBendResults
            {
                ni = ni,
                zasiegStrefySciskanej = zasiegStrefySciskanej,
                As1 = As1,
                As2 = As2
            };

            return result;
        }

        public double CalculationAsmin(double b, double d, double fctm, double fyk)
        {
            return Math.Round(Math.Max(0.01 * 0.0013 * b * d, 0.10 * 0.26 * fctm / fyk), 2);
        }

        public double CalculationAsmax(double b, double d)
        {
            return Math.Round((0.01 * 0.04 * b * d), 2);
        }
    }
}

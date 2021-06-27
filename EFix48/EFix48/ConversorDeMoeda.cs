using System;
using System.Collections.Generic;
using System.Text;

namespace EFix48
{
    class ConversorDeMoeda
    {
        public static double iof = 0.06;

        public static double comprareais(double cota, double compradol)
        {
            return (cota * compradol) * (1 + iof);
        }
    }
}

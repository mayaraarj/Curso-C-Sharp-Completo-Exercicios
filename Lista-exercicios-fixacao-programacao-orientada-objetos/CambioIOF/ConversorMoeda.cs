using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CambioIOF
{
    internal class ConversorMoeda
    {
        public static double Iof = 0.06;

        public static double DolarParaReal(double dolaresComprados, double cotacaoDolar)
        {
            double total = dolaresComprados * cotacaoDolar;
            return total + total * Iof;
        }
    }
}

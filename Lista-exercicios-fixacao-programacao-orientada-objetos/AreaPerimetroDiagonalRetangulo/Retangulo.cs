using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaPerimetroDiagonalRetangulo
{
    internal class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            double area = Largura * Altura;
            return area;
        }

        public double Perimetro()
        {
            double perimetro = 2 * (Largura + Altura);
            return perimetro;
        }

        public double Diagonal ()
        {
            double diagonal = Math.Sqrt ((Largura * Largura )+ (Altura*Altura));
            return diagonal;
        }

    }
}

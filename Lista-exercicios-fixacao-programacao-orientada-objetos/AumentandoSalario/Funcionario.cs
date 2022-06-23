using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace AumentandoSalario
{
    internal class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            double SalarioLiquido = SalarioBruto - Imposto;
            return SalarioLiquido;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto = SalarioBruto + (porcentagem * SalarioBruto) / 100;
        }


        public override string ToString()
        {
            return Nome
                + ", $ "
                + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}

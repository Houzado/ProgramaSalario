using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaSalario
{
    internal class CalcularSalario
    {
        public string Nome;
        public double Bruto;
        public double Imposto;
        public double Porcentagem;

        public double SalarioLiquido()
        {
            return Bruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            Bruto += Bruto * porcentagem / 100;
        }

        public override string ToString()
        {
            return Nome
            + " R$ " + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
            }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalhoPOO.util
{
    public class Investimentos
    {
        public Investimentos(decimal valorInicial, decimal depositoMensal, int prazoInvestimento)
        {
            this.valorInicial = valorInicial;
            this.depositoMensal = depositoMensal;
            this.prazoInvestimento = prazoInvestimento;
        }

        public decimal valorInicial { get; }
        public decimal depositoMensal { get; }
        public int prazoInvestimento { get; }

        public decimal CalcularTesouroSelic()
        {
            return 123;
        }

        public decimal CalcularTesouroIPCA()
        {
            return 123;
        }

        public decimal CalcularCDB()
        {
            return 123;
        }

        public decimal CalcularPoupanca()
        {
            return 123;
        }
    }
}

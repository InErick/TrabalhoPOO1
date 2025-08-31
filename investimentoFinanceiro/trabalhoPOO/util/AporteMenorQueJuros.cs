using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalhoPOO.util
{
    public class AporteMenorQueJuros
    {

        public AporteMenorQueJuros(decimal valorInicial, decimal depositoMensal, int prazoInvestimento)
        {
            this.valorInicial = valorInicial;
            this.depositoMensal = depositoMensal;
            this.prazoInvestimento = prazoInvestimento;
        }

        public decimal valorInicial { get; }
        public decimal depositoMensal { get; }
        public int prazoInvestimento { get; }

        public decimal TesouroSelic()
        {
            return 123;
        }

        public decimal TesouroIPCA()
        {
            return 123;
        }

        public decimal CDB()
        {
            return 123;
        }

        public decimal Poupanca()
        {
            return 123;
        }


    }
}

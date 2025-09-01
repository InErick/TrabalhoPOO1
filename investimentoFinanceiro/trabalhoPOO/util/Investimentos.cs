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
            decimal taxaMensal = Taxas.TaxaMensal(Taxas.TesouroSelic());
            return Calculo(taxaMensal);
        }

        public decimal CalcularTesouroIPCA()
        {
            decimal taxaMensal = Taxas.TaxaMensal(Taxas.TesouroIPCA());
            return Calculo(taxaMensal);
        }

        public decimal CalcularCDB()
        {
            decimal taxaMensal = Taxas.TaxaMensal(Taxas.CDB());
            return Calculo(taxaMensal);
        }

        public decimal CalcularPoupanca()
        {
            decimal taxaMensal = Taxas.TaxaMensal(Taxas.Poupanca());
            return Calculo(taxaMensal);
        }

        private decimal Calculo(decimal taxaMensal)
        {
            decimal saldo = valorInicial;
            for (int mes = 0; mes <= prazoInvestimento; mes++)
            {
                decimal juros = saldo * taxaMensal;
                saldo += juros + depositoMensal;
            }
            return saldo;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalhoPOO.util
{
    public class Detalhamento
    {

        public Detalhamento(decimal valorInicial, decimal depositoMensal, int prazoInvestimento)
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
            return Detalhar(Taxas.TesouroSelic());
        }

        public decimal TesouroIPCA()
        {
            return Detalhar(Taxas.TesouroIPCA());
        }

        public decimal CDB()
        {
            return Detalhar(Taxas.CDB());
        }

        public decimal Poupanca()
        {
            return Detalhar(Taxas.Poupanca());
        }

        private decimal Detalhar(decimal taxaAnual)
        {
            decimal taxaMensal = Taxas.TaxaMensal(taxaAnual);
            decimal saldo = valorInicial;
            
            for (int mes = 1; mes <= prazoInvestimento; mes++)
            {
                decimal juros = saldo * taxaMensal;
                saldo += juros + depositoMensal;

                Console.WriteLine($"Mês {mes}: Saldo: {saldo:C2} (Juros: {juros:C2}, Depósito Mensal: {depositoMensal:C2})");
            }
            return saldo;
        }
    }
}

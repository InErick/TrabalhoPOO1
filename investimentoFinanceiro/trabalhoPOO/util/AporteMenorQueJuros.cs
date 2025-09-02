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

        public void TesouroSelic()
        {
           VerificarCros(Taxas.TesouroSelic());
        }

        public void TesouroIPCA()
        {
            VerificarCros(Taxas.TesouroIPCA());
        }

        public void CDB()
        {
            VerificarCros(Taxas.CDB());
        }

        public void Poupanca()
        {
            VerificarCros(Taxas.Poupanca());
        }

        private void VerificarCros(decimal taxaAnual)
        {
            decimal taxaMensal = Taxas.TaxaMensal(taxaAnual);
            decimal saldo = valorInicial;
            int mesCrossover = 0;

            for (int mes = 1; mes <= prazoInvestimento; mes++)
            {
                decimal juros = saldo * taxaMensal;

                if (mesCrossover == 0 && juros >= depositoMensal)
                {
                    mesCrossover = mes;
                }
                saldo += juros + depositoMensal;
            }

            if (mesCrossover == 0)
            {
                Console.WriteLine("\nOs aportes mensais nunca se tornaram menores que os juros obtidos.");
            }
            else
            {
                Console.WriteLine($"\nOs aportes mensais se tornaram menores que os juros obtidos a partir do mês {mesCrossover}.");
            }


        }
    }
}

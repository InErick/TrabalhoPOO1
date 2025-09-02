using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalhoPOO.util
{
    public class Taxas
    {
        public static decimal TesouroSelic() => 15.0m;

        public static decimal TesouroIPCA() => 4.85m;

        public static decimal CDB() => 12.00m;

        public static decimal Poupanca() => 6.00m;

        public static decimal TaxaMensal(decimal taxaAnual)
        {
            return (taxaAnual / 100m) / 12m;
        }
    }
}

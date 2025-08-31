/*
 Investimento Financeiro: (Equipes 2, 4 e 6) O sistema deverá solicitar ao usuário: O valor 
inicial a ser depositado; os depósitos mensais; o prazo de investimento em anos ou meses. Como 
saída a aplicação deverá fornecer o valor total obtido ao final, tendo por base a taxa do investimento 
no Tesouro Selic, Tesouro IPCA, CDB e Poupança (podem acrescentar outros se desejarem). A taxa de rendimento 
de cada uma dessas aplicações deverá ser pesquisada pela equipe e informada pela aplicação. De acordo com a opção 
de investimento escolhida pelo usuário, deverá ser apresentado o rendimento mês a mês da aplicação até o prazo final.
Deverá também ser indicado a partir de quando os aportes se tornam menores que a taxa de juros obtida no mês. 
Por exemplo: suponha que um investidor deseja aplicar R$500,00 mensalmente por 20 anos. Pode ser que, a partir do 
terceiro ano, a taxa de juros da aplicação sobre o montante já aplicado, supere o valor que o investidor aplica no mês. 
É Esse momento que deverá ser informado também pela aplicação.
 */


using System;
using System.Threading;
using trabalhoPOO.util;

class Program
{
    static void Main(string[] args)
    {

        decimal valorInicial, depositoMensal;
        int periodo, prazoInvestimento;

        Console.Write("- - - Investimento Financeiro - - -\n\n");
        Thread.Sleep(500);

        Console.Write("Olá! Seja bem vindo ao sistema de Investimento Financeiro.\n\n");
        Thread.Sleep(1000);

        while(true)
        {
            Console.Write("- Por favor, informe o valor inicial a ser depositado: R$ ");
            if (decimal.TryParse(Console.ReadLine(), out valorInicial))
                break;
            Console.WriteLine("Valor inválido. Por favor digite apenas números.\n\n");
            //valorInicial = Convert.ToDecimal(Console.ReadLine());
        }
        
        while (true)
        {
            Console.Write("\n- Agora, informe o valor dos depósitos mensais: R$ ");
            if (decimal.TryParse(Console.ReadLine(), out depositoMensal))
                break;
            Console.WriteLine("Valor inválido. Por favor digite apenas números.\n\n");
        }

        do
        {
            while (true)
            {
                Console.Write("\n- Informe o periodo de tempo que deseja investir:\n\n1 - Anos\n2 - Meses\n\nOpção: ");
                if (int.TryParse(Console.ReadLine(), out periodo))
                    break;
                Console.WriteLine("Valor inválido. Por favor digite apenas números inteiros.\n\n");
            }

            switch (periodo)
            {

                case 1:

                    while (true)
                    {
                        Console.Write("\n- Por favor Informe o prazo de investimento em anos: ");
                        if(int.TryParse(Console.ReadLine(), out prazoInvestimento))
                            prazoInvestimento *= 12;
                        break;
                    }

                    break;

                case 2:

                    while (true)
                    {
                        Console.Write("\n- Por favor Informe o prazo de investimento em meses: ");
                        if(int.TryParse(Console.ReadLine(), out prazoInvestimento))
                            break;
                        Console.WriteLine("Valor inválido. Por favor digite apenas números inteiros.\n\n");
                    }

                    break;

                default:
                    Console.WriteLine("Opção inválida, escolha uma opção disponivel!");
                    prazoInvestimento = 0;
                    break;

            };

        } while (prazoInvestimento == 0);


        Console.Write("\nCalculando...\n\n");
        Thread.Sleep(1000);

        Investimentos investimentos = new Investimentos(valorInicial, depositoMensal, prazoInvestimento);


        Console.WriteLine("Investindo nas seguintes opções terá os seguintes resultados: \n");

        Console.WriteLine($"-> Tesouro Selic: {investimentos.CalcularTesouroSelic()}");
        Console.WriteLine($"-> Tesouro IPCA: {investimentos.CalcularTesouroIPCA()}");
        Console.WriteLine($"-> CDB: {investimentos.CalcularCDB()}");
        Console.WriteLine($"-> Poupança: {investimentos.CalcularPoupanca()}");



    }
 
}
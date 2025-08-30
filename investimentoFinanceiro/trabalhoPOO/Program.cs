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

        Console.Write("- Por favor, informe o valor inicial a ser depositado: R$ ");
        valorInicial = Convert.ToDecimal(Console.ReadLine());

        Console.Write("\n- Agora, informe o valor dos depósitos mensais: R$ ");
        depositoMensal = Convert.ToDecimal(Console.ReadLine());

        Console.Write("\n- Informe o periodo de tempo que deseja investir:\n1 - Anos\n2 - Meses\nOpção: ");
        periodo = int.Parse(Console.ReadLine());

    
            
        switch (periodo)
        {

            case 1:

                Console.Write("\n- Por favor Informe o prazo de investimento em anos: ");
                prazoInvestimento = int.Parse(Console.ReadLine()) * 12;

                break;

            case 2:

                Console.Write("\n- Por favor Informe o prazo de investimento em meses: ");
                prazoInvestimento = int.Parse(Console.ReadLine());

                break;

            default:
                Console.WriteLine("Opção inválida, escolha uma opção disponivel!");
                break;

        };

        Console.Write("\nCalculando...\n\n");
        Thread.Sleep(1000);






    }
 
}
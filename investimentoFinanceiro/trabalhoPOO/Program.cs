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
            Console.WriteLine("Valor inválido. Por favor digite apenas números.\n");
            //valorInicial = Convert.ToDecimal(Console.ReadLine());
        }
        Console.Clear();

        while (true)
        {
            Console.Write("\n- Agora, informe o valor dos depósitos mensais: R$ ");
            if (decimal.TryParse(Console.ReadLine(), out depositoMensal))
                break;
            Console.WriteLine("Valor inválido. Por favor digite apenas números.\n");
        }
        Console.Clear();

        do
        {
            while (true)
            {
                Console.Write("\n- Informe o periodo de tempo que deseja investir:\n\n1 - Anos\n2 - Meses\n\nOpção: ");
                if (int.TryParse(Console.ReadLine(), out periodo))
                    break;
                Console.WriteLine("Valor inválido. Por favor digite apenas números inteiros.\n");
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
                        Console.WriteLine("Valor inválido. Por favor digite apenas números inteiros.\n");
                    }

                    break;

                case 2:

                    while (true)
                    {
                        Console.Write("\n- Por favor Informe o prazo de investimento em meses: ");
                        if(int.TryParse(Console.ReadLine(), out prazoInvestimento))
                            break;
                        Console.WriteLine("Valor inválido. Por favor digite apenas números inteiros.\n");
                    }

                    break;

                default:
                    Console.WriteLine("Opção inválida, escolha uma opção disponivel!");
                    prazoInvestimento = 0;
                    break;

            };

        } while (prazoInvestimento == 0);


        Console.Clear();
        Console.Write("\nCalculando...");
        Thread.Sleep(1000);

        Investimentos investimentos = new Investimentos(valorInicial, depositoMensal, prazoInvestimento);
        Taxas taxas = new Taxas();
        Detalhamento detalhamento = new Detalhamento(valorInicial, depositoMensal, prazoInvestimento);
        AporteMenorQueJuros aporteMenorQueJuros = new AporteMenorQueJuros(valorInicial, depositoMensal, prazoInvestimento);


        Console.Clear();    
        Console.WriteLine("----- Resultados do Investimento -----\n\n");
        Console.WriteLine($"Você investiu R$ {valorInicial} inicialmente, com depósitos mensais de R$ {depositoMensal}, por um período de {prazoInvestimento} meses.\n");
        Console.WriteLine("Investindo nas seguintes opções terá os seguintes resultados: \n");

        Console.WriteLine($"1 -> Tesouro Selic: {investimentos.CalcularTesouroSelic():c2}\nTaxa de redimento: {Taxas.TesouroSelic()}%/ano");
        Console.WriteLine(" ");
        Console.WriteLine($"2 -> Tesouro IPCA: {investimentos.CalcularTesouroIPCA():c2}\nTaxa de redimento: {Taxas.TesouroIPCA()}%/ano");
        Console.WriteLine(" ");
        Console.WriteLine($"3 -> CDB: {investimentos.CalcularCDB():c2}\nTaxa de redimento: {Taxas.CDB()}%/ano");
        Console.WriteLine(" ");
        Console.WriteLine($"4 -> Poupança: {investimentos.CalcularPoupanca():c2}\nTaxa de redimento: {Taxas.Poupanca()}%/ano");

        Console.WriteLine(" ");
        Console.WriteLine(" ");


        int opcaoInvestimento;
        do
        {
            while (true)
            {
                Console.Write("Quais das opcoes de investimento você gostaria de fazer? (Digite o número da opção): ");
                if (int.TryParse(Console.ReadLine(), out opcaoInvestimento))
                    break;
                Console.WriteLine("Valor inválido. Por favor digite apenas números inteiros.\n");
            }
            switch(opcaoInvestimento)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("- - - Tesouro Selic - - -\n");
                    detalhamento.TesouroSelic();
                    aporteMenorQueJuros.TesouroSelic();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("- - - Tesouro IPCA - - -\n");
                    detalhamento.TesouroIPCA();
                    aporteMenorQueJuros.TesouroIPCA();
                    break;
                case 3: 
                    Console.Clear();
                    Console.WriteLine("- - - CDB - - -\n"); 
                    detalhamento.CDB();
                    aporteMenorQueJuros.CDB();
                    break;
                case 4: 
                    Console.Clear();
                    Console.WriteLine("- - - Poupança - - -\n");
                    detalhamento.Poupanca();
                    aporteMenorQueJuros.Poupanca();
                    break;
                default:
                    opcaoInvestimento = 0;
                    break;
            }


        } while (opcaoInvestimento == 0);

        Console.WriteLine("\n\nObrigado por utilizar nosso sistema de Investimento Financeiro!");

    }
 
}
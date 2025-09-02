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

        while (true)
        {
            Console.Write("- Por favor, informe o valor inicial a ser depositado: R$ ");

            if (decimal.TryParse(Console.ReadLine(), out valorInicial))
            {

                if (valorInicial > 1_000_000_000_000_000m)
                {
                    Console.WriteLine("Valor muito alto! Por favor insira um valor menor.\n");
                    continue;
                }

                if (valorInicial < 0)
                {
                    Console.WriteLine("O valor inicial não pode ser negativo.\n");
                    continue;
                }

                break;
            }

            Console.WriteLine("Valor inválido. Por favor digite apenas números.\n");
        }

        Console.Clear();

        while (true)
        {

            Console.Write("\n- Agora, informe o valor dos depósitos mensais: R$ ");

            if (decimal.TryParse(Console.ReadLine(), out depositoMensal))
            {

                if (depositoMensal < 0)
                {
                    Console.WriteLine("O valor do depósito não pode ser negativo.\n");
                    continue;
                }

                if (depositoMensal > 1_000_000_000_000m)
                {
                    Console.WriteLine("Valor muito alto! Insira um depósito mensal menor.\n");
                    continue;
                }

                break;

            }

            Console.WriteLine("Valor inválido. Por favor, digite apenas números.\n");

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

                        Console.Write("\n- Por favor, informe o prazo de investimento em anos: ");

                        if (int.TryParse(Console.ReadLine(), out prazoInvestimento))
                        {
                            if (prazoInvestimento <= 0)
                            {
                                Console.WriteLine("O prazo deve ser maior que zero.\n");
                                continue;
                            }

                            if (prazoInvestimento > 100)
                            {
                                Console.WriteLine("Prazo muito alto! Informe no máximo 100 anos.\n");
                                continue;
                            }

                            prazoInvestimento *= 12;
                            break;
                        }

                        Console.WriteLine("Valor inválido. Por favor, digite apenas números inteiros.\n");

                    }

                    break;

                case 2:

                    while (true)
                    {
                        Console.Write("\n- Por favor, informe o prazo de investimento em meses: ");

                        if (int.TryParse(Console.ReadLine(), out prazoInvestimento))
                        {
                            if (prazoInvestimento <= 0)
                            {
                                Console.WriteLine("O prazo deve ser maior que zero.\n");
                                continue;
                            }

                            if (prazoInvestimento > 1200)
                            {
                                Console.WriteLine("Prazo muito alto! Informe no máximo 1200 meses (100 anos).\n");
                                continue;
                            }

                            break;
                        }

                        Console.WriteLine("Valor inválido. Por favor, digite apenas números inteiros.\n");
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

        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey(true);

    }
 
}
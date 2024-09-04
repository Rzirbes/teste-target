class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Escolha um exercício para executar:");
                Console.WriteLine("1. Calcular Soma");
                Console.WriteLine("2. Verificar número na sequência de Fibonacci");
                Console.WriteLine("3. Analisar faturamento diário");
                Console.WriteLine("4. Calcular percentual de representação de estados");
                Console.WriteLine("5. Inverter string");
                Console.WriteLine("6. Sair");

                int escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        Exercicio1.CalcularSoma();
                        break;
                    case 2:
                        Exercicio2.VerificarFibonacci();
                        break;
                    case 3:
                        Exercicio3.AnalisarFaturamento();
                        break;
                    case 4:
                        Exercicio4.CalcularPercentual();
                        break;
                    case 5:
                        Exercicio5.InverterString();
                        break;
                    case 6:
                        return;
                    default:
                        Console.WriteLine("Escolha inválida. Tente novamente.");
                        break;
                }

                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
                Console.ReadKey();
            }
        }
    }
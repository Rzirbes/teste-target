class Exercicio3
    {
        public static void AnalisarFaturamento()
        {
            // Exemplo de valores de faturamento para simplificar
            double[] faturamentoDiario = new double[] { 100, 200, 0, 300, 150, 0, 250, 80, 0, 120 };
            double menorValor = faturamentoDiario.Where(x => x > 0).Min();
            double maiorValor = faturamentoDiario.Max();
            double mediaMensal = faturamentoDiario.Where(x => x > 0).Average();
            int diasAcimaDaMedia = faturamentoDiario.Count(x => x > mediaMensal);

            Console.WriteLine("Menor valor de faturamento: " + menorValor);
            Console.WriteLine("Maior valor de faturamento: " + maiorValor);
            Console.WriteLine("Dias com faturamento acima da média: " + diasAcimaDaMedia);
        }
    }

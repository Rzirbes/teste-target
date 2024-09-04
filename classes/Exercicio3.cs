using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

class Exercicio3
{
    public class Faturamento
    {
        public double Dia { get; set; }
        public double Valor { get; set; }
    }

    public static void AnalisarFaturamento()
    {
        // Obtém o caminho do diretório atual do projeto
        string diretorioProjeto = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;

        // Concatena o caminho do arquivo com o diretório do projeto
        string caminhoArquivo = Path.Combine(diretorioProjeto, "../faturamento.json");

        // Carrega o JSON do arquivo
        string json = File.ReadAllText(caminhoArquivo);
        List<Faturamento> faturamentoMensal = JsonConvert.DeserializeObject<List<Faturamento>>(json);

        // Filtra os dias com faturamento > 0
        var diasComFaturamento = faturamentoMensal.Where(f => f.Valor > 0).ToList();

        // Calcula o menor e maior valor de faturamento
        double menorValor = diasComFaturamento.Min(f => f.Valor);
        double maiorValor = diasComFaturamento.Max(f => f.Valor);

        // Calcula a média mensal
        double mediaMensal = diasComFaturamento.Average(f => f.Valor);

        // Conta os dias com faturamento acima da média
        int diasAcimaDaMedia = diasComFaturamento.Count(f => f.Valor > mediaMensal);

        // Exibe os resultados
        Console.WriteLine("Menor valor de faturamento: " + menorValor);
        Console.WriteLine("Maior valor de faturamento: " + maiorValor);
        Console.WriteLine("Dias com faturamento acima da média: " + diasAcimaDaMedia);
    }
}
using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

class Program
{
    public class Faturamento
    {
        public int dia { get; set; }
        public double valor { get; set; }
    }

    static void Main()
    {
        string json = File.ReadAllText("MultipleFiles/dados.json");
        List<Faturamento> dados = JsonConvert.DeserializeObject<List<Faturamento>>(json);

        List<double> valores = new List<double>();
        foreach (var d in dados)
        {
            if (d.valor > 0)
            {
                valores.Add(d.valor);
            }
        }

        double menorValor = double.MaxValue;
        double maiorValor = double.MinValue;
        double soma = 0;

        foreach (var valor in valores)
        {
            if (valor < menorValor) menorValor = valor;
            if (valor > maiorValor) maiorValor = valor;
            soma += valor;
        }

        double mediaMensal = soma / valores.Count;
        int diasAcimaMedia = 0;

        foreach (var valor in valores)
        {
            if (valor > mediaMensal) diasAcimaMedia++;
        }

        Console.WriteLine($"Menor valor: {menorValor}");
        Console.WriteLine($"Maior valor: {maiorValor}");
        Console.WriteLine($"Número de dias acima da média: {diasAcimaMedia}");
    }
}
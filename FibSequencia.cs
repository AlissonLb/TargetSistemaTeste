using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Informe um número: ");
        int numero = int.Parse(Console.ReadLine());
        List<int> fibSequencia = Fibonacci(numero);

        if (fibSequencia.Contains(numero))
        {
            Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"O número {numero} não pertence à sequência de Fibonacci.");
        }
    }

    static List<int> Fibonacci(int n)
    {
        List<int> fibSequencia = new List<int> { 0, 1 };
        int a = 0, b = 1;

        while (b <= n)
        {
            int next = a + b;
            fibSequencia.Add(next);
            a = b;
            b = next;
        }
        return fibSequencia;
    }
}
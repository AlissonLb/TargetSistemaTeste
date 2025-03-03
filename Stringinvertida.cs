using System;

class Program
{
    static void Main()
    {
        Console.Write("Informe uma string: ");
        string input = Console.ReadLine();
        string inverted = InverterString(input);
        Console.WriteLine($"String invertida: {inverted}");
    }

    static string InverterString(string s)
    {
        string invertida = "";
        for (int i = 0; i < s.Length; i++)
        {
            invertida = s[i] + invertida;
        }
        return invertida;
    }
}
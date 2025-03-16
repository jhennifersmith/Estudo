
using System;

public static class Tabuada
{
    public static void Tabuadaa()
    {
        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine()!);

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{numero} x {i} = {numero * i}");
        }
    }
}

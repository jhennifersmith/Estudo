
using System;

public static class ParImpar
{
    public static void ParOuImpar()
    {
        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine()!);

        if (numero % 2 == 0)
            Console.WriteLine("O número é par.");
        else
            Console.WriteLine("O número é ímpar.");
    }
}

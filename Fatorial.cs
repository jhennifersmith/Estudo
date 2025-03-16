
using System;

public static class Fatorial
{
    public static void Fatoriall()
    {
        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine()!);

        for (int i = numero - 1; i >= 1; i--)
        {
            numero = numero * i;
            Console.WriteLine($"{numero} x {i} = {numero}");
        }
    }
}

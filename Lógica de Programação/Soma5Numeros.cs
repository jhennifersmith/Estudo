
using System;

public static class Soma5Numeros
{
    public static void Soma()
    {
        Console.Write("Digite o primeiro número: ");
        int numero1 = int.Parse(Console.ReadLine()!);
        Console.Write("Digite o segundo número: ");
        int numero2 = int.Parse(Console.ReadLine()!);
        Console.Write("Digite o terceiro número: ");
        int numero3 = int.Parse(Console.ReadLine()!);
        Console.Write("Digite o quarto número: ");
        int numero4 = int.Parse(Console.ReadLine()!);
        Console.Write("Digite o quinto número: ");
        int numero5 = int.Parse(Console.ReadLine()!);
        int soma = numero1 + numero2 + numero3 + numero4 + numero5;
        Console.Write("A soma total é: " + soma);
    }
}

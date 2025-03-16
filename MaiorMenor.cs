
using System;

public static class MaiorMenor
{
    public static void MaiorEMenor()
    {
        // Console.Write("Digite um número: ");
        // int numero = int.Parse(Console.ReadLine()!);
        // Console.Write("Digite o segundo número: ");
        // int numero2 = int.Parse(Console.ReadLine()!);
        // Console.Write("Digite o terceiro número: ");
        // int numero3 = int.Parse(Console.ReadLine()!);
        // Console.Write("Digite o último número: ");
        // int numero4 = int.Parse(Console.ReadLine()!);

        // if (numero > numero2 && numero > numero3 && numero > numero4)
        // {
        //     Console.WriteLine("O maior número é: " + numero);
        // }
        // else if (numero2 > numero && numero2 > numero3 && numero2 > numero4)
        // {
        //     Console.WriteLine("O maior número é: " + numero2);
        // }
        // else if (numero3 > numero && numero3 > numero2 && numero3 > numero4)
        // {
        //     Console.WriteLine("O maior número é: " + numero3);
        // }
        // else
        // {
        //     Console.WriteLine("O maior número é: " + numero4);
        // }

        int[] numeros = new int[4];

        for (int i = 0; i < 4; i++)
        {
            Console.Write($"Digite o {i + 1}º número: ");
            numeros[i] = int.Parse(Console.ReadLine()!);
        }

        int maior = numeros[0];
        int menor = numeros[0];

        for (int i = 1; i < numeros.Length; i++)
        {
            if (numeros[i] > maior)
                maior = numeros[i];

            if (numeros[i] < menor)
                menor = numeros[i];
        }

        Console.WriteLine($"O maior número é: {maior}");
        Console.WriteLine($"O menor número é: {menor}");

    }
}

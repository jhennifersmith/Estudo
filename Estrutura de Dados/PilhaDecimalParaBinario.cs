using System;

public static class PilhaDecimalParaBinario
{
    public static void DecimalParaBinario()
    {
        //PILHA//
        //Implemente uma função que converte um número decimal (base 10) em seu equivalente binário (base 2) utilizando uma pilha.
        Console.Write("Digite um número decimal: ");
        int numero = int.Parse(Console.ReadLine()!);

        Stack<int> pilha = new Stack<int>();

        while (numero > 0)
        {
            pilha.Push(numero % 2);
            numero /= 2;
        }

        Console.Write("Número binário: ");
        while (pilha.Count > 0)
        {
            Console.Write(pilha.Pop());
        }
    }
}

using System;

public static class PilhaReverterString
{
    public static void ReverterString()
    {
        //PILHA//
        //Escreva uma função que usa uma pilha para inverter uma string.
        Console.Write("Digite uma palavra: ");
        string palavra = Console.ReadLine();

        Stack<char> pilha = new Stack<char>();
        foreach (char c in palavra)
        {
            pilha.Push(c);
        }
        while (pilha.Count > 0)
        {
            Console.Write(pilha.Pop());
        }
    }
}

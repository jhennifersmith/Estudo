using System;

public static class PilhaRemoverCaracterRepetido
{
    public static void RemoverCaracterRepetido()
    {
        //PILHA//
        //Dada uma string s, remova os caracteres consecutivos duplicados usando uma pilha.
        Console.Write("Digite uma palavra: ");
        string palavra = Console.ReadLine();

        Stack<char> pilha = new Stack<char>();
        foreach (char c in palavra)
        {
            if (pilha.Count > 0 && pilha.Peek() == c)
            {
                pilha.Pop();
                continue;
            }
            pilha.Push(c);
        }
        List<char> resultado = new List<char>();
        while (pilha.Count > 0)
        {
            resultado.Add(pilha.Pop());
        }

        resultado.Reverse();
        new string(resultado.ToArray());
        Console.WriteLine("Palavra sem caracteres repetidos: " + new string(resultado.ToArray()));
    }
}


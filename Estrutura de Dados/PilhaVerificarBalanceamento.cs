using System;

public static class PilhaVerificarBalanceamento
{
    public static bool VerificarBalanceamento(string expressao)
    {
        //PILHA//
        //Crie uma função que recebe uma string contendo parênteses e verifica se estão balanceados. Ou seja, cada parêntese de abertura ( deve ter um correspondente de fechamento ).
        Stack<char> pilha = new Stack<char>();

        foreach (char caractere in expressao)
        {
            if (caractere == '(')
            {
                pilha.Push(caractere);
            }
            else if (caractere == ')')
            {
                if (pilha.Count == 0)
                    return false;

                pilha.Pop();
            }
        }
        var resultado = pilha.Count == 0;
        Console.WriteLine($"A expressão '{expressao}' está balanceada? {resultado}");
        return pilha.Count == 0;

    }
}

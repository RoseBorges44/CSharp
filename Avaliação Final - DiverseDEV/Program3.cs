using System;

class Program3
{
    static void Main()
    {
        Console.Write("Digite uma frase: ");
        string frase = Console.ReadLine();

        // Divide a frase em palavras usando espaços como delimitadores
        string[] palavras = frase.Split(' ');

        int maiusculas = 0;
        int minusculas = 0;
        int maiusculaInicio = 0;
        int minusculaInicio = 0;

        foreach (string palavra in palavras)
        {
            if (palavra.Length > 0)
            {
                if (char.IsUpper(palavra[0]))
                {
                    maiusculaInicio++;
                }
                else
                {
                    minusculaInicio++;
                }

                if (palavra == palavra.ToUpper())
                {
                    maiusculas++;
                }
                else if (palavra == palavra.ToLower())
                {
                    minusculas++;
                }
            }
        }

        int totalPalavras = palavras.Length;

        Console.WriteLine($"Palavras maiúsculas: {maiusculas}");
        Console.WriteLine($"Palavras minúsculas: {minusculas}");
        Console.WriteLine($"Palavras que iniciam com letra maiúscula: {maiusculaInicio}");
        Console.WriteLine($"Palavras que iniciam com letra minúscula: {minusculaInicio}");
        Console.WriteLine($"Total de palavras: {totalPalavras}");
    }
}
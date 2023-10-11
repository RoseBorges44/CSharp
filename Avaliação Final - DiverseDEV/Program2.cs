using System;

public class Program
{
    public static void Main(string[] args)
    {

        int n1 = 0;
        int n2 = 0;

        try
        {
            Console.WriteLine("Digite o primeiro número:");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            n2 = int.Parse(Console.ReadLine());

            int multiplicacao = 0;
            for (int i = 0; i < n2; i++)
            {
                multiplicacao += n1;
            }

            int divisao = 0;

            if (n2 != 0)
            {
                while (n1 >= n2)
                {
                    divisao++;
                    n1 -= n2;
                }
            }
            else
            {
                Console.WriteLine("Multiplicação: {0}", multiplicacao);
                Console.WriteLine("Divisão: NÃO É POSSÍVEL DIVIDIR POR 0");
                return;
            }

            Console.WriteLine("Multiplicação: {0}", multiplicacao);
            Console.WriteLine("Divisão: {0}", divisao);
        }
        catch (FormatException e)
        {
            Console.WriteLine("Erro de formato: Digite números inteiros.");
        }
    }
}
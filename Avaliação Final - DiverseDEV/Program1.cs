﻿using System;

class Program1
{
    static void Main()
    {
        int[] numeros = new int[5];

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Digite o {i + 1}º número: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        int pares = 0;
        int impares = 0;
        int positivos = 0;
        int negativos = 0;

        foreach (int numero in numeros)
        {
            if (numero % 2 == 0)
                pares++;
            else
                impares++;

            if (numero > 0)
                positivos++;
            else if (numero < 0)
                negativos++;
        }

        Console.WriteLine($"{pares} valor(es) par(es)");
        Console.WriteLine($"{impares} valor(es) ímpar(es)");
        Console.WriteLine($"{positivos} valor(es) positivo(s)");
        Console.WriteLine($"{negativos} valor(es) negativo(s)");
    }
}
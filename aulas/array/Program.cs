﻿internal class Program
{
    private static void Main(string[] args)
    {
        int[] numeros = new int[10];

        int[] pares = new int[10];
        int[] impares = new int[10];

        for (int p = 0; p < numeros.Length; p++)
        {
            Console.WriteLine("Digite um número maior que zero");
            numeros[p] = Convert.ToInt32(Console.ReadLine());
        }

        for (int p = 0; p < numeros.Length; p++)
        {
            if (numeros[p] % 2 == 0)
            {
                pares[p] = numeros[p];
            }
            else
            {
                impares[p] = numeros[p];
            }
        }

        // ORDENAÇÃO DOS VETORES
        Array.Sort(numeros);
        Array.Sort(pares);
        Array.Sort(impares);

        Array.Reverse(numeros);
      

        Console.WriteLine("\n\nESTES SÃO OS NÚMEROS QUE VOCÊ DIGITOU");
        foreach (int num in numeros)
        {
            Console.WriteLine(num);
        }

        Console.WriteLine("\n\nESTES SÃO OS NÚMEROS QUE VOCÊ DIGITOU de forma invertida");
        foreach (int num in numeros)
        {
            Console.WriteLine(num);
        }

        Console.WriteLine("\n\nESTES SÃO OS PARES");
        foreach (int num in pares)
        {
            if (num != 0) Console.WriteLine(num);
        }

        Console.WriteLine("\n\nESTES SÃO OS ÍMPARES");
        foreach (int num in impares)
        {
            if (num != 0) Console.WriteLine(num);
        }
    
    }
}
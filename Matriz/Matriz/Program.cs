using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int m = int.Parse(s[0]);
            int n = int.Parse(s[1]);

            int[,] matriz = new int[m,n];

            //Implementação de um for dentro do outro para poder, selecionar a linha e coluna,
            //sendo i = linha; f = coluna
            for (int i = 0; i < m; i++)
            {
                string[] s1 = Console.ReadLine().Split(' ');

                for (int f = 0; f < n; f++)
                {
                    matriz[i,f] = int.Parse(s1[f]);
                }
            }
            // Para poder imprimir o valor é necessário uma estrutura for dos mesmos valores
            //sendo i = linha; f = coluna
            for (int i = 0; i < m;i++)
            {
                for(int f = 0; f < n;f++)
                {
                    // Write sem o Line para poder manter os valores na mesma linha
                    Console.Write(matriz[i,f] + " ");
                }

                Console.WriteLine();
            }

        }
    }
}
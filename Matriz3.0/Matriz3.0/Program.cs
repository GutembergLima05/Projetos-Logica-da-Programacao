using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int m = int.Parse(s[0]);
            int n = int.Parse(s[1]);
            //Colocando o valor de m sendo linhas e n representando colunas
            int[,] matriz = new int[m, n];

            for(int i = 0; i < m; i++)
            {
               s = Console.ReadLine().Split(' ');

                //Agora é feita a posição da matriz
                //sendo i linhas e j colunas
                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(s[j]);
                }

            }
            // Vetor com "m" Colunas
            int[] vet = new int[m];

            for(int i = 0; i < m;i++)
            {
                int soma = 0;
                for(int j = 0; j < n; j++)
                {
                    soma = soma + matriz[i,j];
                }

                vet[i] = soma;
            }

            for (int i = 0; i < m; i++)
            {
                Console.WriteLine(vet[i]);
            }
            
        }
    }
}
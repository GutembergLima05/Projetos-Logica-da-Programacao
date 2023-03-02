using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matriz;
            matriz = new int[n,n];
            int cont = 0;
            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');

                for(int j =0; j < n; j++)
                {
                    matriz[i,j] = int.Parse(s[j]);

                    if (matriz[i,j] < 0)
                    {
                        cont++;
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Diagonal Principal: ");

            for (int i = 0; i <n; i++)
            {
                Console.Write(matriz[i,i] + " ");
            }
            Console.WriteLine();

                Console.WriteLine("Numeros negativos é: " + cont);
        }
    }
}
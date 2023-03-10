using System.Globalization;
using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] nomes = new string[n];
            int[] idades = new int[n];
            double[] altura = new double[n];

            //Leitura dos dados 
            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                nomes[i] = s[0];
                idades[i] = int.Parse(s[1]);
                altura[i] = double.Parse(s[2], CultureInfo.InvariantCulture);

            }

            //Calculo da altura média
            double soma = 0.0;
            for (int i = 0 ; i < n; i++)
            {
                soma = soma = altura[i];
            }

            double media = soma / n;
            Console.WriteLine("Altura média: " + media.ToString("F2", CultureInfo.InvariantCulture));

            //Porcentagem de pessoas abaixo de 16 anos

            int cont = 0;
            for (int i = 0; i < n; i++)
            {
                if (idades[i] < 16)
                {
                    cont++;
                }
            }
            double porcentagem = (double)cont / n * 100.0;

            Console.WriteLine("Pessoas com menos de 16 anos: " +
                porcentagem.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
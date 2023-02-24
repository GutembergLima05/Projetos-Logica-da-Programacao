using System;
using System.Globalization;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            double idade, soma = 0.0;
            double media;
            int cont = 0;
            idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (idade >= 0)
            {
                soma = soma + idade;
                cont = cont + 1;
                idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            if (cont == 0)
            {
                Console.WriteLine("Impossível Calcular");
            }
            else
            {
                media = soma / cont;
                Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
            }

        }
    }
}
using System;
using System.Globalization;
using System.Runtime.Serialization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            double cont = 0.0, soma = 0.0, dados;

            dados = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (dados > 0)
            {
                cont++;
                soma = soma + dados;
                dados = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            dados = soma / cont;
            Console.WriteLine(dados.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
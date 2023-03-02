using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] produtos = new string[n];
            double[] compra = new double[n];
            double[] venda = new double[n];
            double somavenda = 0.0,somacompra = 0.0;

            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                produtos[i] = s[0];
                compra[i] = double.Parse(s[1],CultureInfo.InvariantCulture);
                venda[i] = double.Parse(s[2], CultureInfo.InvariantCulture);

                somacompra += compra[i];
                somavenda += venda[i];
            }

            double lucro1 = 0.0;
            int cont10 = 0;
            int cont20 = 0;
            int cont = 0;
            for (int i = 0; i < n; i++)
            {
                lucro1 = venda[i] - compra[i];

                if (lucro1 < compra[i] * 10.0 / 100.0)
                {
                    cont10++;
                } else if ( lucro1 >= compra[i] * 10.0 / 100.0 && lucro1 <= compra[i] * 20.0 / 100.0)
                {
                    cont20++;
                } else 
                {
                    cont++;
                }

            }
            Console.WriteLine("Lucro abaixo de 10%: " + cont10);
            Console.WriteLine("Lucro entre 10% e 20%: " + cont20);
            Console.WriteLine("Lucro acima de 20%: " + cont);
            Console.WriteLine("Valor total de compra: " + somacompra.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor total de venda: " + somavenda.ToString("F2", CultureInfo.InvariantCulture));

            double total = somavenda - somacompra;
            Console.WriteLine("Lucro total: " + total.ToString("F2", CultureInfo.InvariantCulture));
           
        }
    }
}
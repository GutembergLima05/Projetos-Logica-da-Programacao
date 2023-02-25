using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            string[] valores = Console.ReadLine().Split(' ');

            x = double.Parse(valores[0]);
            y = double.Parse(valores[1]);

            while (x != 0 && y != 0)
            {
                if (x > 0.0 && y < 0.0)
                {
                    Console.WriteLine("quarto");
                }
                else if (x > 0.0 && y > 0.0)
                {
                    Console.WriteLine("primeiro");
                }
                else if (x < 0.0 && y > 0.0)
                {
                    Console.WriteLine("segundo");
                }
                else
                {
                    Console.WriteLine("terceiro");
               
                }

                valores = Console.ReadLine().Split(' ');
                x = Double.Parse(valores[0]);
                y = Double.Parse(valores[1]);
            }
        }
    }
}
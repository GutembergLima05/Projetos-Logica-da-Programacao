using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 2;

            while (numero <= 100)
            {
                Console.WriteLine(numero);
                numero = numero + 2;
            }
        }
    }
}
using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, calc;

            N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                calc = i * N;
                Console.WriteLine(i + " x " + N + " = " + calc);
            }
        }
    }
}
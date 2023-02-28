using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                double calc = 0.0;
                i++;
                if (i % 2 == 0)
                {
                    calc = Math.Pow(i, 2.0);
                }

                Console.WriteLine(i.ToString("F0") + "^" + "2 = " + calc);
            }
        }
    }
}
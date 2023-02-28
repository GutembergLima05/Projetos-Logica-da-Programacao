using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int inn = 0;
            int outt = 0;
            for (int i = 1; i <= n; i++)
            {
                int x = int.Parse(Console.ReadLine());
              
                if (x >= 10 && x <= 20)
                {
                    inn++;
                } else
                {
                    outt++;
                }
            }

            Console.WriteLine(inn + " in");
            Console.WriteLine(outt + " out");
        }
    }
}
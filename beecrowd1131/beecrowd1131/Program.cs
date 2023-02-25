using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int empate = 0, grenais = 0,vitoriaInter = 0, vitoriaGremio = 0;
            int novoCalculo = 1;

            while (novoCalculo == 1)
            {
                string[] valores = Console.ReadLine().Split(' ');
                int inter = int.Parse(valores[0]);
                int gremio = int.Parse(valores[1]);

                grenais++;

                if (inter == gremio)
                {
                    empate++;
                } else if (inter > gremio)
                {
                    vitoriaInter++;
                } else
                {
                    vitoriaGremio++;
                }
                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                novoCalculo = int.Parse(Console.ReadLine());

                while (novoCalculo != 1 && novoCalculo !=2)
                {
                    Console.WriteLine("Novo grenal (1-sim 2-nao)");
                    novoCalculo = int.Parse(Console.ReadLine());
                }

            }

            Console.WriteLine(grenais + " grenais");
            Console.WriteLine("Inter:" + vitoriaInter);
            Console.WriteLine("Gremio:" + vitoriaGremio);
            Console.WriteLine("Empates:" + empate);

            if (vitoriaInter > vitoriaGremio)
            {
                Console.WriteLine("Inter venceu mais");
            }
            else
            {
                Console.WriteLine("Gremio venceu mais");
            }

        }
    }
}
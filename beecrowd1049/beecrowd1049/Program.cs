using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string escolha1 = Console.ReadLine();
            string escolha2 = Console.ReadLine();
            string escolha3 = Console.ReadLine();

            if (escolha1 == "vertebrado")
            {
                if (escolha2 == "ave")
                {
                    if (escolha3 == "carnivoro")
                    {
                        Console.WriteLine("aguia");
                    }
                    else if (escolha3 == "onivoro")
                    {
                        Console.WriteLine("pomba");
                    }
                }
                else if (escolha2 == "mamifero")
                {
                    if (escolha3 == "onivoro")
                    {
                        Console.WriteLine("homem");
                    }
                    else if (escolha3 == "herbivoro")
                    {
                        Console.WriteLine("vaca");
                    }
                }
            }
            else if (escolha1 == "invertebrado")
            {
                if (escolha2 == "inseto")
                {
                    if (escolha3 == "hematofago")
                    {
                        Console.WriteLine("pulga");
                    } else if (escolha3 == "herbivoro")
                    {
                        Console.WriteLine("lagarta");
                    }
                } else if (escolha2 == "anelideo")
                {
                    if (escolha3 == "hematofago")
                    {
                        Console.WriteLine("sanguessuga");
                    } else if (escolha3 == "onivoro")
                    {
                        Console.WriteLine("minhoca");
                    }
                }
            }
        }
    }
}
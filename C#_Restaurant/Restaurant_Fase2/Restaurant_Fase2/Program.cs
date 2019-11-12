using System;
using System.Collections.Generic;

namespace Restaurant
{
    class Program
    {
        static int Ordenar = 0;
        
        static void Main(string[] args)
        {
            int[] Billets = new int[6];
            double preuTotal;
            string[] plats = new string[5];
            decimal[] preuPlats = new decimal[5];

            Console.WriteLine(
            "\n" +
            "\n" +
            "\n" +
             "----- Restaurants Fase 2 -->  omple Noms i Preus dels plats " +
            "\n" +
            "\n");

            var lst_Pedido = new List<string>();
            int f = 0;
            for (int i = 0; i < plats.Length; i++)
            {
                f += 1;
                Console.WriteLine("Nom del plat número " + f + ":");
                plats[i] = Console.ReadLine();
                Console.WriteLine("Preu: ");
                string Preu = Console.ReadLine();
                preuPlats[i] = Convert.ToDecimal(Preu);
                Console.WriteLine("---------------");
            }
            Console.WriteLine();
            //Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("MENU del Restaurant");
            //Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            f = 0;
            
            foreach (string element in plats)
            {
                f = f + 1;
               Console.Write("{0}\t{1}\n",element, preuPlats[f - 1]);
            }

            Console.WriteLine("Desitja demanar el menjar? (s/n)");
            string volmenjar = Console.ReadLine();
            
            
            if (volmenjar == "s")
            {
                Ordenar = 1;
            }

            else
            {
                Console.WriteLine("Encantats de servir-lo.....Adéu i gracies!");
                Environment.Exit(1);
            }

          
            while (Ordenar == 1)
            {
                Console.WriteLine("Si us plau...Escrigui el Plat que vol demanar:");
                string plato = Console.ReadLine();
                lst_Pedido.Add(plato);
                Console.WriteLine("Desitja Seguir demanant?(s/n)");
                volmenjar = Console.ReadLine();

                    if ( volmenjar== "s")
                    {
                        Ordenar = 1;
                    }

                    else
                    {
                        Ordenar = 0;
                    }

            }

        }
    }
}
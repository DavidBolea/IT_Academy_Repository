using System;
using System.Collections.Generic;

namespace Restaurant
{
    class Program
    {
        static int Ordenar = 0; // utilizada para saber si se quiere realizar pedido del plato  o no
        static int p; //variable de varios usos (1- para saber si los platos del Pedido están en el Menú,2....)

        public class Track //declarada clase con los campos que se utilizarán en la list de Pedido
        {
            public int TrackID { get; set; }
            public string namePlat { get; set; }
            public decimal Preu { get; set; }
        }

        static void Main(string[] args)
        {
            int[] Billets = new int[6];
            decimal preuTotal = 0;
            string[] plats = new string[5];
            decimal[] preuPlats = new decimal[5];

            Console.WriteLine(
            "\n" +
            "\n" +
            "\n" +
             "----- Restaurants Fase 3 --------------------------" +
            "\n" +
            "\n");

            var lst_Pedido = new List<Track>(); //declara lista donde guarda el pedido de los platos
            int f = 0;

            //elminar  rellena los platos
            plats[0] = "Gambas";
            preuPlats[0] = 12;
            plats[1] = "Ostras";
            preuPlats[1] = 7;
            plats[2] = "Mandonguilles";
            preuPlats[2] = 6;
            plats[3] = "Sushi";
            preuPlats[3] = 4;
            plats[4] = "Cargols";
            preuPlats[4] = 8;


            Console.WriteLine(); // Aplica formato de colores a la Consola
            //Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("MENU del Restaurant");
            //Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            f = 0;

            for (int i = 0; i < plats.Length; i++) // imprime el Menú
            {
                if (plats[i].Length < 12)
                {
                    Console.Write("{0}\t\t{1}\n", plats[i], preuPlats[i]);
                }
                else
                {
                    Console.Write("{0}\t{1}\n", plats[i], preuPlats[i]);
                }

            }
        comença:;
            Console.WriteLine(
                "\n" +
                "Desitja demanar el menjar? (s/n)");
            string volmenjar = Console.ReadLine();

            switch (volmenjar)
            {
                case "s":
                    Ordenar = 1;
                    break;
                case "n":
                    Console.WriteLine("Encantats de servir-lo.....Adéu i gracies!");// si no quiere pedir ningún plato sale del programa
                    Console.ReadLine();
                    Environment.Exit(1);
                    break;
                default:
                    Console.WriteLine("Resposta incorrecta!.... si us plau teclegi s o n");
                    goto comença;
            }

        ferPedido:

            while (Ordenar == 1)//Toma nota del pedido
            {
                f += 1;
                Console.WriteLine("Si us plau...Escrigui el Plat que vol demanar:");

                lst_Pedido.Add(new Track
                {
                    TrackID = f,
                    namePlat = Console.ReadLine()
                });
            torna:;

                Console.WriteLine("Desitja Seguir demanant?(s/n)");


                volmenjar = Console.ReadLine();

                switch (volmenjar)
                {
                    case "s":
                        Ordenar = 1;
                        break;
                    case "n":
                        Ordenar = 0;
                        break;
                    default:
                        Console.WriteLine("Resposta incorrecta!.... si us plau teclegi s o n");
                        goto torna;
                }
            }

            for (int x = 0; x < lst_Pedido.Count; x++)// compara el Pedido(lst Pedido)  con el Menú(plats[])
            {
                string platopedido = lst_Pedido[x].namePlat;
                for (int i = 0; i < plats.Length; i++)
                {
                    if (platopedido == plats[i])
                    {
                        p += 1;
                        lst_Pedido[x].Preu = preuPlats[i];
                        preuTotal += preuPlats[i];
                    }
                }

            }


            if (p == lst_Pedido.Count) //Imprime el Pedido
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(
                    "\n" + 
                    "La seva Comanda es:");
                Console.ForegroundColor = ConsoleColor.White;
                for (int x = 0; x < lst_Pedido.Count; x++)

                {
                    if (lst_Pedido[x].namePlat.Length < 12)
                    {
                        Console.Write("{0}\t\t{1} Euros\n", lst_Pedido[x].namePlat, lst_Pedido[x].Preu);
                    }
                    else
                    {
                        Console.Write("{0}\t{1} Euros\n", lst_Pedido[x].namePlat, lst_Pedido[x].Preu);
                    }

                }
                Console.WriteLine(
                "\n" +
                "---------------------------\n" +
                "Preu Total ....." + preuTotal + " Euros" +
                "\n" +
                "\n"); 
            }

            else
            {
                lst_Pedido.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(
                    "\n" + 
                    "Un producte demanat no existeix al Menú ");
            }


            Console.ReadLine();
        }
    }
}
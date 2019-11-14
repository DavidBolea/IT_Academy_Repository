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
            int[] Billets = new int[7];
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

            Billets[0] = 5;
            Billets[1] = 10;
            Billets[2] = 20;
            Billets[3] = 50;
            Billets[4] = 100;
            Billets[5] = 200;
            Billets[6] = 500;



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
                Console.WriteLine(// imprime el pedido y el precioTotal
                "\n" +
                "---------------------------\n" +
                "Preu Total ....." + preuTotal + " Euros" +
                "\n" +
                "\n");


                decimal calc_Billets;
                decimal resto;
                for (int i = Billets.Length - 1; i>=0; i--) // calcula forma de pago
                {
                    calc_Billets = preuTotal / Billets[i];
                    if (calc_Billets >= 1)
                    {
                        if (calc_Billets > 1) //analiza si tiene que pagar con + de 1 billete de este tipo
                        {
                            int number = Decimal.ToInt32(calc_Billets); // nos quedamos con las parte entera del número
                            Console.WriteLine("Has de pagar amb " + number +" billet/s de " + Billets[i] + " Euros.");
                            resto = preuTotal - (Billets[i] * number);
                        }

                        else
                        {
                        Console.WriteLine("has de pagar amb un billet/s de :" + Billets[i] + " Euros.");//tiene que pagar con 1 billete de este tipo
                            resto = preuTotal - Billets[i];
                        //Console.WriteLine("el que falta per pagar es : " + resto);

                            if (resto == 0) { break; };


                        }
                            for (int z = i ; z >= 0; z--)
                            {
                                calc_Billets = resto / Billets[z];

                                if (calc_Billets >= 1) // analiza con cuantos Billetes debe pagar de este tipo
                                {
                                    if (calc_Billets > 1) // analiza si tiene que pagar con + de 1 Billete de este tipo
                                {
                                        int number = Decimal.ToInt32(calc_Billets); // nos quedamos con la parte entera del número
                                        Console.WriteLine("També has de pagar amb " + number + " billet/s de " + Billets[z] + " Euros.");
                                        resto = resto - (Billets[z] * number);
                                    }

                                    else //tiene que pagar con 1 billete de este tipo
                                    {
                                        Console.WriteLine("També has de pagar amb un billet/s de " + Billets[z] + " Euros.");
                                        resto = (resto - Billets[z]);
                                    }
                                }

                        }
                        if (resto != 0) {
                            Console.WriteLine("El resto : " + resto + " Euro/s, ho has de pagar amb monedes.");
                            break;
                        }
                    }
                }
            }

            else
            {
                lst_Pedido.Clear();// si un plato que se ha pedido no está en el menú, vuelve a pedir que se haga la "comanda"
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(
                    "\n" + 
                    "Un producte demanat no existeix al Menú\n" +
                    "Si us plau torni a fer la comanda....gracies");
                lst_Pedido.Clear();
                p = 0;
                preuTotal = 0;
                Ordenar = 1;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                goto ferPedido;
            }


            Console.ReadLine();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nom_Ciutats__Fase_2_
{
    class Program
    {
        private static int i;


        static void Main(string[] args)
        {
            Console.WriteLine(
     "\n" +
     "\n" +
     "\n" +
      "----- Noms Ciutats Fase 1 ---------------" +
    "\n");
            string Ciutat0;
            string Ciutat1;
            string Ciutat2;
            string Ciutat3;
            string Ciutat4;
            string Ciutat5;


            Console.WriteLine("Introdueix el nom de la 1a Ciutat");
            Ciutat0 = Console.ReadLine();

            Console.WriteLine("Introdueix el nom de la 2a Ciutat");
            Ciutat1 = Console.ReadLine();

            Console.WriteLine("Introdueix el nom de la 3a Ciutat");
            Ciutat2 = Console.ReadLine();

            Console.WriteLine("Introdueix el nom de la 4a Ciutat");
            Ciutat3 = Console.ReadLine();

            Console.WriteLine("Introdueix el nom de la 5a Ciutat");
            Ciutat4 = Console.ReadLine();

            Console.WriteLine("Introdueix el nom de la 6a Ciutat");
            Ciutat5 = Console.ReadLine();


            Console.WriteLine(
         "\n" +
         "\n" +
         "\n" +
          "----- les dades s'han emmagatzemat de la següent manera---------------" +
        "\n");

            Console.WriteLine("La variable Ciutat0 guarda....... " + Ciutat0);
            Console.WriteLine("La variable Ciutat1 guarda....... " + Ciutat1);
            Console.WriteLine("La variable Ciutat2 guarda....... " + Ciutat2);
            Console.WriteLine("La variable Ciutat3 guarda....... " + Ciutat3);
            Console.WriteLine("La variable Ciutat4 guarda....... " + Ciutat4);
            Console.WriteLine("La variable Ciutat5 guarda....... " + Ciutat5);


            Console.WriteLine(
            "\n" +
            "\n" +
            "\n" +
             "----- Noms Ciutats Fase 2 ---------------" +
           "\n");
            string[] array_Ciutats = new string[6]; // paso datos a array

            array_Ciutats[0] = Ciutat0;
            array_Ciutats[1] = Ciutat1;
            array_Ciutats[2] = Ciutat2;
            array_Ciutats[3] = Ciutat3;
            array_Ciutats[4] = Ciutat4;
            array_Ciutats[5] = Ciutat5;


            Console.WriteLine(
         "\n" +
         "\n" +
         "\n" +
          "----- les dades s'han emmagatzemat en un array de la següent manera---------------" +
        "\n");

            for (i = 0; i < Ciutat.Length; i++)
            {
                Console.WriteLine("Ciutat[" + i + "] = " + Ciutat[i]);
            }

            Console.ReadLine();
        }
    }
}
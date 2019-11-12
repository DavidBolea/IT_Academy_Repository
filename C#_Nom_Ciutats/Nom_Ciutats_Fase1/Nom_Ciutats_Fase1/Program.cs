using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nom_Ciutats__Fase_1_
{
    class Program
    {
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

            Console.ReadLine();

        }
    }
}
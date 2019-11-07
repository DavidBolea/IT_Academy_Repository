using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercici_Variables
{
    class Program
    {
        public const int any_Traspàs = 1948;
        public const int periode = 4;
        
        static void Main(string[] args)
        {
            Console.WriteLine(
           "\n" +
           "//----- Variables Fase 1 -----------------" +
           "\n");

            string nom = "David";
            string cognom1 = "Bolea";
            string cognom2 = "Sancho";
            int dia = 23;
            int mes = 04;
            int any = 1973;
            Console.WriteLine(nom + " " + cognom1 + " " + cognom2);
            Console.WriteLine(dia + "/" + mes + "/" + any);

            Console.WriteLine(
            "\n" +
            "\n" +
            "\n" +
             "//----- Variables Fase 2 -----------------" +
           "\n");


            int Anys_Transcurreguts = 1973 - any_Traspàs;
            int result = Anys_Transcurreguts / 4;
            int Any_Result = any_Traspàs;
            bool coincideix = false;
            String text_Coinc = "El meu any de naixement SI es un any de traspàs.";
            String text_No_Coinc = "El meu any de naixement NO es un any de traspàs.";


            Console.WriteLine(
            "Número d'anys de traspàs entre 1948 i el meu naixement: {0}", result);

            Console.WriteLine(
            "\n" +
            "\n" +
            "\n" +
             "//----- Variables Fase 3 -----------------" +
           "\n");

            for (int i = 0; i < result; i++)
            {
                Any_Result = Any_Result + periode;
                Console.WriteLine("Any de traspàs: {0}", Any_Result);
            }

            if (Any_Result == 1973)
            {
                coincideix = true;
                Console.WriteLine("La variable bool es certa.");
            }
            else
            {
                coincideix = false;
                Console.WriteLine("la variable bool no es certa ({0}).", coincideix);
            }

            Console.WriteLine(
             "\n" +
             "\n" +
             "\n" +
              "//----- Variables Fase 4 -----------------" +
            "\n");

            string[] NouNom = new string[] { "David", "Bolea", "Sancho" };
            int[] nascut = new int[] { 23, 4, 1973 };


            Console.WriteLine("El meu nom es {0} {1} {2}", NouNom[0], NouNom[1], NouNom[2]);

            Console.WriteLine("Vaig néixer el: {0}/{1}/{2}", nascut[0], nascut[1], nascut[2]);

            
            
            Console.WriteLine(text_No_Coinc);

            Console.ReadLine();


        }
    }
}

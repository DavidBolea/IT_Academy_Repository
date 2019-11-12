using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Reflection;

namespace Nom_Ciutats__Fase_2_
{
    class Program
    {
        private static int i;

        public static String sin_acentos(string palabra)
        {

            string textoOriginal = palabra;//transformación UNICODE
            string textoNormalizado = textoOriginal.Normalize(NormalizationForm.FormD);
            //coincide todo lo que no sean letras y números ascii o espacio
            //y lo reemplazamos por una cadena vacía.
            Regex reg = new Regex("[^a-zA-Z0-9]");
            string textoSinAcentos = reg.Replace(textoNormalizado, "");

            return textoSinAcentos;

        }
        public static string Reverse(string s)// invierte orden de los caracteres de una cadena 
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);

        }
        

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
             "----- Noms Ciutats Fase 2 -  array_Ciutats ordenat Alfabèticament---------------" +
           "\n");
            string[] array_Ciutats = new string[6]; // paso datos al array

            array_Ciutats[0] = Ciutat0;
            array_Ciutats[1] = Ciutat1;
            array_Ciutats[2] = Ciutat2;
            array_Ciutats[3] = Ciutat3;
            array_Ciutats[4] = Ciutat4;
            array_Ciutats[5] = Ciutat5;

            Array.Sort(array_Ciutats); // ordena array alfabéticamente

            foreach (string str in array_Ciutats) Console.Write(str + "\n"); // imprime Array


            Console.WriteLine(
            "\n" +
            "\n" +
            "\n" +
             "----- Noms Ciutats Fase 3 -  array_Ciutats Canvia la lletra a --> 4 " +
           "\n");

            string[] ArrayCiutatsModificades = new string[array_Ciutats.Length];
            string[] nomInveritCiutat = new string[array_Ciutats.Length];

            for (i = 0; i < array_Ciutats.Length; i++)
            {
                ArrayCiutatsModificades[i] = array_Ciutats[i];

                ArrayCiutatsModificades[i]= sin_acentos(ArrayCiutatsModificades[i]);// llama a la Funcion Pública "sin_acentos"

                ArrayCiutatsModificades[i] = ArrayCiutatsModificades[i].Replace("a", "4");

                nomInveritCiutat[i] = Reverse(array_Ciutats[i]);// llama a la Funcion Pública "Reverse"
            }

            foreach (string str2 in ArrayCiutatsModificades) Console.Write(str2 + "\n"); // imprime Array

            Console.WriteLine(
            "\n" +
            "\n" +
            "\n" +
             "----- Noms Ciutats Fase 4 -  Noms invertits---------------" +
           "\n");
            
            string[] lletresInvertides = new string[nomInveritCiutat[0].Length];

                    for ( i = 0; i < nomInveritCiutat[0].Length; i++) 
                    
                    {
                        lletresInvertides[i] = nomInveritCiutat[0].Substring(i, 1);
    
                    }
                    Console.WriteLine(array_Ciutats[0] + " - " + nomInveritCiutat[0]);
                   
               
            string[] lletresInvertides1 = new string[nomInveritCiutat[1].Length];

                    for (i = 0; i < nomInveritCiutat[1].Length; i++) 

                    {
                        lletresInvertides1[i] = nomInveritCiutat[1].Substring(i, 1);

                    }
                    Console.WriteLine(array_Ciutats[1] + " - " + nomInveritCiutat[1]);

                
            string[] lletresInvertides2 = new string[nomInveritCiutat[2].Length];

                    for (i = 0; i < nomInveritCiutat[2].Length; i++) 

                    {
                        lletresInvertides2[i] = nomInveritCiutat[2].Substring(i, 1);

                    }
                    Console.WriteLine(array_Ciutats[2] + " - " + nomInveritCiutat[2]);

            string[] lletresInvertides3 = new string[nomInveritCiutat[3].Length];

                    for (i = 0; i < nomInveritCiutat[3].Length; i++) 

                    {
                        lletresInvertides3[i] = nomInveritCiutat[3].Substring(i, 1);

                    }
                    Console.WriteLine(array_Ciutats[3] + " - " + nomInveritCiutat[3]);

                
            string[] lletresInvertides4 = new string[nomInveritCiutat[4].Length];

                    for (i = 0; i < nomInveritCiutat[4].Length; i++) 

                    {
                        lletresInvertides4[i] = nomInveritCiutat[4].Substring(i, 1);

                    }
                    Console.WriteLine(array_Ciutats[4] + " - " + nomInveritCiutat[4]);

                
            string[] lletresInvertides5 = new string[nomInveritCiutat[5].Length];

                    for (i = 0; i < nomInveritCiutat[5].Length; i++)

                    {
                        lletresInvertides5[i] = nomInveritCiutat[5].Substring(i, 1);

                    }
                    Console.WriteLine(array_Ciutats[5] + " - " + nomInveritCiutat[5]);

             Console.ReadLine();
        }
        
    }
}
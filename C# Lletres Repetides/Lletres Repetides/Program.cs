using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lletres_Repetides
{
      class Program
      {
        public int repeatcount(string str, char ch) // funcion publica para contar caracteres repetidos
        {

            var count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (ch == str[i])
                {
                    count++;
                }

            }

            return count;
        }


        static void Main(string[] args)
        {

            string myName = "David";
            string mySurname = "Bolea";
            string[] compName = new string[myName.Length];
            
            Console.WriteLine(
            "\n" +
            "\n" +
             "----- Lletres Repetides -Array- (Fase 1) ---------------" +
            "\n");


            for (int i = 0; i < myName.Length; i++) //Extrae las letras de la cadena de texto

            {
                compName[i] = myName.Substring(i, 1);
                Console.WriteLine("\t" + i + " = " + compName[i]);
            }

            Console.WriteLine(
           "\n" +
           "\n" +
           "\n" +
            "----- Lletres Repetides (Fase 2) ---------------" +
          "\n");

            var lst_Name = new List<string>(); // crea un list (lst_Name) e introduce datos desde el array my_Name

            for (int i = 0; i < myName.Length; i++)
            {
                lst_Name.Add(compName[i]);

            }


            int result;

            foreach (string element in lst_Name) // recorre la lista e imprime si son vocales, consonantes o numeros
            {
                int.TryParse(element, out result); //mira si es un número*

                if (element == "a" || element == "e" || element == "i" || element == "o" || element == "u")
                {
                    Console.WriteLine("\t" + element + " VOCAL");
                    goto Outer;
                }

                if (element == " ")
                {
                    Console.WriteLine();
                    goto Outer;
                }

                if (result != 0) // *si es diferente de 0 ........
                {
                    Console.WriteLine("Els noms de persones no contenen números!");
                    goto Outer;
                }

                else
                {
                    Console.WriteLine("\t" + element + " CONSONANT");
                }
            Outer:
                continue;
            }

            Console.WriteLine(
            "\n" +
            "\n" +
            "\n" +
             "----- Lletres Repetides (Fase 3) ---------------" +
           "\n");

            IDictionary<int, string> dict_Name = new Dictionary<int, string>(); // Crea Diccionario y recibe los valores de la lisa lst_Name
            int f = 0;

            foreach (string element in lst_Name)
            {
                f = f + 1;
                dict_Name.Add(f, element);
            }

            for (int i = 0; i < myName.Length; i++)
            {
                char ch = Convert.ToChar(myName.ToLower().Substring(i, 1));
                Program obj = new Program();
                int p = obj.repeatcount(myName.ToLower(), ch);
                string letter = Convert.ToString(ch);
                f = f + 1;
                dict_Name.Add(f, letter);
                Console.WriteLine("\tLa letra " + ch + " se ha repetido " + p + " veces");
            }

            Console.WriteLine(
          "\n" +
          "\n" +
          "\n" +
           "----- Lletres Repetides -Surname_List- (Fase 4) ---------------" +
         "\n");

            var lst_Surname = new List<string>(); // crea un list_Surname e introduce datos desde string mySurname (letra x letra)

            for (int i = 0; i < mySurname.Length; i++)
            {
                lst_Surname.Add(mySurname.Substring(i, 1));
            }
            Console.WriteLine();
            lst_Surname.ForEach(i => Console.Write("\t{0}\n", i)); //Imprime la lita lst_Surname


           Console.WriteLine(
          "\n" +
          "\n" +
          "\n" +
           "----- Lletres Repetides -FullName_List- (Fase 4)  ---------------" +
         "\n");

            var lst_FullName = new List<string>(); //Crea la lista con Nombre y Apellidos (lst_Fullname) y la rellena
            lst_FullName.AddRange(lst_Name);
            lst_FullName.Add(" ");
            lst_FullName.AddRange(lst_Surname);

            Console.WriteLine();
            lst_FullName.ForEach(i => Console.Write("\t{0}\n", i)); //imprime la lista lst_Fullname

            Console.ReadLine();
        }
      }
}

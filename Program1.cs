using System;
using System.Collections.Generic;

namespace ConsoleApp41
{
    class Program1
    {
        static void Main(string[] args)
        {
            List<char> nom = new List<char>();
            List<char> cognom = new List<char>();

            try
            {
                nom = crearnom();
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                cognom = crearnom();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            ajuntar(nom, cognom);

           

        }

        public static void ajuntar (List<char> array1,List<char> array2)
        {
            List<char> fullname = new List<char>();
            Dictionary<char, int> count = new Dictionary<char, int>();
            int num;
            foreach (char i in array1)
            {
                fullname.Add(i);

                if (count.ContainsValue(i))
                {
                    num = count[i];
                    num++;
                    count[i] = num;
                }
                else                
                    count.Add(i, 1);
                
            }
               

            fullname.Add(' ');

            foreach (char i in array2)
            {
                fullname.Add(i);

                if (count.ContainsKey(i))
                {
                    num = count[i];
                    num++;
                    count[i] = num;
                }
                else
                    count.Add(i, 1);

            }

            Console.WriteLine("\n  Fullname");

            foreach (char i in fullname)
                Console.WriteLine(i);

            foreach (KeyValuePair<char, int> valor in count)
                Console.WriteLine("key {0} -> valor {1} ", valor.Key, valor.Value);
        }

        public static List<char> crearnom()
        {
            List<char> array = new List<char>();

            Console.WriteLine("Fica el teu nom!");
            string nom = Console.ReadLine();

            foreach (char ch in nom.ToCharArray())
            {
                if (Char.IsLetter(ch))
                    array.Add(ch);
                else
                    throw new ArgumentException("El nom no conte numeros");
            }

            Console.WriteLine("\n");

            foreach (char i in array)
            {
                if (char.IsUpper(i))
                    Console.WriteLine("VOCAL");
                else
                    Console.WriteLine("CONSONTANT");

                Console.WriteLine(i);
            }
              

            return array;
        }
    }
}

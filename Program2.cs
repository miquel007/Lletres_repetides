using System;
using System.Collections.Generic;

namespace ConsoleApp43
{
    class Program2
    {
        static void Main(string[] args)
        {
            escala1();

            escala2();

            escala3();
        }

        public static void escala1()
        {
            List<string> array = new List<string>();
            string lista = "";

            Console.WriteLine("Mida piramide");
            string Kfake = Console.ReadLine();
            int num = Convert.ToInt32(Kfake);
            
            int pap = 0;

            while (pap < num+1)
            {
                for (int i = 1; i < pap+1; i++)
                {
                    lista = lista + i;
                }
                array.Add(lista);
                lista = "";
                pap++;
            }

            foreach (string caso in array)
                Console.WriteLine(caso);
        }

        public static void escala2()
        {
            List<string> array = new List<string>();
            string lista = "";

            Console.WriteLine("Mida piramide");
            string Kfake = Console.ReadLine();
            int num = Convert.ToInt32(Kfake);

            int pap = 0;
            int mitad = num / 2;
            int par = num % 2;

            if  (par == 0)
            {
                for (int i = 0; i < mitad; i++) 
                    lista = lista + " ";

                lista = lista + "**";

                for (int i = 0; i < mitad; i++)
                    lista = lista + " ";
                array.Add(lista);
                pap = pap + 2;
            }
            else
            {
                for (int i = 0; i < mitad; i++)
                    lista = lista + " ";

                lista = lista + "*";

                for (int i = 0; i < mitad; i++)
                    lista = lista + " ";
                array.Add(lista);
                pap++;
            }

            lista = "";
            mitad--;
            
            while (pap < num)
            {
                pap = pap + 2;

                for (int i = 0; i < mitad; i++)
                    lista = lista + " ";

                for (int i = 0; i < pap; i ++)
                    lista = lista + "*";

                for (int i = 0; i < mitad; i++)
                    lista = lista + " ";

                
                array.Add(lista);
                lista = "";
                mitad--;
            }

            foreach (string caso in array)
                Console.WriteLine(caso);
        }

        public static void escala3()
        {
            List<string> array = new List<string>();
            string lista = "";

            Console.WriteLine("Mida piramide");
            string Kfake = Console.ReadLine();
            int num = Convert.ToInt32(Kfake);

            int pap = 2;
            int par = num % 2;

            

            while (pap < num+1)
            {
                for (int i = 0; i < pap/2; i++)
                    lista = lista + " ";

                for (int i = 0; i < num-pap+2; i++)
                    lista = lista + "*";

                for (int i = 0; i < pap/2; i++)
                    lista = lista + " ";

                pap = pap + 2;
                array.Add(lista);
                lista = "";
                

                if (par != 0 && pap == num+1)
                {
                    for (int i = 0; i < pap / 2; i++)
                        lista = lista + " ";

                    lista = lista + "*";

                    for (int i = 0; i < pap / 2; i++)
                        lista = lista + " ";

                    pap = pap + 2;
                    array.Add(lista);
                    lista = "";
                }
            }

           

            foreach (string caso in array)
                Console.WriteLine(caso);
        }
    }
}

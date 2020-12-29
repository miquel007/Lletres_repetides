using System;
using System.Threading;

namespace ConsoleApp44
{
    class Program3
    {
        static void Main(string[] args)
        {
            int houre, min, seg;
           
            string fmt = "00.##";

            bool trobat = true;

            while (trobat)
            {
                for( houre = 0; houre < 24; houre++)
                {
                    for(min = 0; min < 60; min++)
                    {
                        for(seg = 0; seg < 60; seg++)
                        {
                            Console.WriteLine(houre.ToString(fmt) + ":" + min.ToString(fmt) + ":" + seg.ToString(fmt));
                            Thread.Sleep(1000);
                        }
                    }
                }
            }



            
        }
    }
}

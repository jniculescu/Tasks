using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Jani Niculescu
 15.2.2017
 IF Task 3
 */

namespace IF_task_3
{
    class Program
    {
        static void Main(string[] args)
        {

          Console.WriteLine("Anna numero: ");
           int i = int.Parse(Console.ReadLine());
          string posneg = "negatiivinen";
          string B = "pariton";

            if (i >= 1)
            {
              posneg = "positiivinen";
            }

            if (i <= -1)
            {
               posneg = "negatiivinen";
            }


            if (i % 2 == 1)
            {
                B = "Pariton";
            }
            
            if (i % 2 == 0)
            {
                 B = "Parillinen";
            }

            Console.WriteLine("Numero " + i + " on " + posneg + " ja " + B + ".");
            Console.ReadKey();
        }
    }
}

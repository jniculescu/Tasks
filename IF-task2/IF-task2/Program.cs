using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
  Jani Niculescu
  14.2.2017
  IF task 2
 */

namespace IF_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;

            Console.Write("Anna numero : ");
            i = int.Parse(Console.ReadLine());

            if (i % 2 == 1)
            {
                Console.WriteLine("Luku on pariton");
                Console.ReadKey();
            }

            else
            {
                Console.WriteLine("Luku on parillinen");
                Console.ReadKey();
            }

        }
    }
}

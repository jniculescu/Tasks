using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Jani Niculescu
 IF statement Task 1
 14,2.2017
 */

namespace IF_task
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;

            Console.WriteLine("Anna numero");
            i = int.Parse(Console.ReadLine());

            if (i == 0)
            {
                Console.WriteLine("Numero on nolla");
                Console.ReadKey();
            }

            if (i <= -1)
            {
                Console.WriteLine("Numero" + i + " on negatiivinen");
                Console.ReadKey();
            }

            if (i >= 1)
            {
                Console.WriteLine("Numero" + i + " on positiivinen");
                Console.ReadKey();
            }
        }
    }
}

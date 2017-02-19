using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Jani Niculescu 19.2.2017 Loop task 1

namespace Loop_Task_1
{
    class Program
    {
        static void Main(string[] args)
        {

            int N = 0;
            int summa = 1;

            //input
            Console.Write("Anna numero: ");
            N = int.Parse(Console.ReadLine());

            //num check
            if (N < 1)
            {
                Console.WriteLine("Määrittelemätön numero.");
                Console.ReadKey();
            }

            //kertomisen looppi
            for (int i = 1; i <= N; i++)
            {
                summa = summa * i;
            }

            Console.WriteLine("Summa: " + summa);
            Console.ReadKey();

        }
    }
}

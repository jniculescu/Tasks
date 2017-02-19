using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Jani Niculescu 19.2.2017 Loop Task 
namespace Loop_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 0;
            int summa = 0;

            //input
            Console.Write("Anna N arvo: ");
            N = int.Parse(Console.ReadLine());

            //numeron tarkistus
            if (N < 1)
            {
                Console.WriteLine("Määrittelemätön numero.");
                Console.ReadKey();
            }

            //kertomisen looppi
            for (int i = 1; i <= N; i++)
            {
                summa = summa + i;
            }

            Console.WriteLine("Summa: " + summa);
            Console.ReadKey();


        }
    }
}

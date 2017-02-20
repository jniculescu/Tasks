using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Jani Niculescu 19.2.2017 Loop Task 2
namespace Loop_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 0;
            int sum = 0;

            //input
            Console.Write("Give value for N: ");
            N = int.Parse(Console.ReadLine());

            //num check
            if (N < 1)
            {
                Console.WriteLine("Undefined number.");
                Console.ReadKey();
            }

            //loop
            for (int i = 1; i <= N; i++)
            {
                sum = sum + i;
            }

            Console.WriteLine("Summa: " + sum);
            Console.ReadKey();


        }
    }
}

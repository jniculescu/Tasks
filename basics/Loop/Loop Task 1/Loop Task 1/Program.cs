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
            int sum = 1;

            //input
            Console.Write("Enter number: ");
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
                sum = sum * i;
            }

            Console.WriteLine("Sum: " + sum);
            Console.ReadKey();

        }
    }
}

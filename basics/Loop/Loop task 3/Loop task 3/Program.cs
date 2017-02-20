using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_task_3
{
    class Program
    {
        //Jani Niculescu 20.2.2017 Loop task 3
        static void Main(string[] args)
        {
            int N = 0;
            int sum1 = 0;
            int sum2 = 0;

            //input
            Console.Write("Enter number: ");
            N = int.Parse(Console.ReadLine());

            //Looping
            for (int i = 1; i <= N; i++)
            {
                //even number
                if (i % 2 == 0)
                {
                    sum1 = sum1 + i;
                }
                //odd number
                else
                {
                    sum2 = sum2 + i;
                }
            }

            Console.WriteLine("Even sum: " + sum1);
            Console.WriteLine("Odd sum: " + sum2);
            Console.ReadKey();
        }
    }
}

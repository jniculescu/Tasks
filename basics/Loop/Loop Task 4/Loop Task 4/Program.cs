using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Jani Niculescu 19.2.2017 Loop Task 4
namespace Loop_Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 0;
            int sum = 0;
            
            //input
            Console.Write("Enter number: ");
            N = int.Parse(Console.ReadLine());

            //Looping

            //positive num
            if(N > 0)
            {
                for (int i = 1; i <= N; i++)
                {
                    sum = sum + i;
                }
            }

            //negative num
            if (N < 0)
            {
                for (int i = -1; i >= N; i--)
                {
                    sum = sum + (i);
                }
            }

            Console.WriteLine("Sum: " + sum);
            Console.ReadKey();
        }
    }
}

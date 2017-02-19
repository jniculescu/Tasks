using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 0;
            int summa1 = 0;
            int summa2 = 0;

            //input
            Console.Write("Anna numero: ");
            N = int.Parse(Console.ReadLine());

            //Loopin

            if (N > 0)
            {
                for (int i = 1; i <= N; i++)
                {
                    //even number
                    if (i % 2 == 0)
                    {
                        summa1 = summa1 + i;
                    }
                    //odd number
                    else
                    {
                        summa2 = summa2 + i;
                    }
                }
            }

            else
            {
         
                for (int i = -1; i >= N; i--)
                {
                    //even number
                    if (i % 2 == 0)
                    {
                        summa1 = summa1 + (i);
                    }
                    //odd number
                    else
                    {
                        summa2 = summa2 + (i);
                    }
                }

            }

            Console.WriteLine("Parillisten summa: " + summa1);
            Console.WriteLine("Parittomien summa: " + summa2);
            Console.ReadKey();
        }
    }
}

﻿using System;
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
            int sum1 = 0;
            int sum2 = 0;

            //input
            Console.Write("Enter number: ");
            N = int.Parse(Console.ReadLine());

            //Loopin

            if (N > 0)
            {
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
            }

            else
            {
         
                for (int i = -1; i >= N; i--)
                {
                    //even number
                    if (i % 2 == 0)
                    {
                        sum1 = sum1 + (i);
                    }
                    //odd number
                    else
                    {
                        sum2 = sum2 + (i);
                    }
                }

            }

            Console.WriteLine("Even sum: " + sum1);
            Console.WriteLine("Odd sum: " + sum2);
            Console.ReadKey();
        }
    }
}

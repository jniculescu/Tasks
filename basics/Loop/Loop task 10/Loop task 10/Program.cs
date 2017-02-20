using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_task_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            for (int i = 1; i <= 13; i++)
            {
                double y = rnd.NextDouble();

                Console.Write(i + ". ");

                if (y >= 0 && y < 0.4)
                {
                    Console.Write("1");
                }
                else if (y >= 0.4 && y < 0.6)
                {
                    Console.Write("x");
                }
                else
                {
                    Console.Write("2");
                }

                Console.WriteLine(" ");

            }
            Console.ReadKey();
        }
    }
}

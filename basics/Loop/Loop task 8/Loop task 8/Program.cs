using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_task_8
{
    class Program
    {
        //Jani Niculescu 20.2.2017 Loop task 8
        static void Main(string[] args)
        {
            Random rnd = new Random();

            for(int i = 1; i <= 4; i++)
            {
              Console.Write("Rivi" + i + ": ");
              for(int x = 1; x <= 5; x++)
                {
                  int y = rnd.Next(50);
                    Console.Write(y);
                    Console.Write(", ");
                }
                Console.Write("\n");
            }
            Console.ReadKey();

        }
    }
}

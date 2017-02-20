using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_Task_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int sixes = 0;
            Random rnd = new Random();

            for (int i = 1; i <= 1000; i++)
            {
                int dice = rnd.Next(6);

                if (dice == 5)
                {
                    sixes++;
                }

                Console.WriteLine(i + ". " + dice);
            }

            Console.WriteLine("Six rolled " + sixes + " times.");
            Console.ReadKey();
        }
    }
}

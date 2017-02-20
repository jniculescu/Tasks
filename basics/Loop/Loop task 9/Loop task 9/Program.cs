using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_task_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int heads = 0;
            int tails = 0;
            int i = 1;
            Random rnd = new Random();

            for (i = 1; i <= 20; i++)
            {
                int y = rnd.Next(2);

                    if(y == 0)
                        {
                            heads++;
                        }
                    if(y == 1)
                        {
                            tails++;
                        }
            }

            Console.WriteLine("Coin has been tossed 20 times.");
            Console.WriteLine("Heads came " + heads + " and tails " + tails + "times.");
            Console.ReadKey();
        }
    }
}

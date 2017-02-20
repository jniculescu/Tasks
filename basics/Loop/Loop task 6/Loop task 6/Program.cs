using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number     Squareroot");

            for(int i = 0; i<= 10; i++)
            {
                double sqrt = Math.Sqrt(i);
                Console.WriteLine(i + "      " + sqrt);
            }
            Console.ReadKey();
        }
    }
}

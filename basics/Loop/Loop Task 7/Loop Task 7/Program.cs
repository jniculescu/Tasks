using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_Task_7
{
    class Program
    {
        //Jani Niculescu 20.2.2017 Loop task 7
        static void Main(string[] args)
        {
            for (int x = 1; x <= 9; x++)
            {
                for (int i = 1; i <= 10; i++)
                {
                    int multi = x * i;
                    Console.WriteLine(x + " X  " + i + " = " + multi);
                }
            }
            Console.ReadKey();
        }
    }
}

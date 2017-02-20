using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func_task_1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            int number = int.Parse(Console.ReadLine());
            Asterisks(number);

        }

        static public void Asterisks(int number)
        {
            int amount = number;

            for (int i = 1; i <= amount; i++)
            {
                Console.Write("*");
            }

            Console.ReadKey();
        }
    }
}

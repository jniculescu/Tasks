using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions_task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give a number: ");
            int Num1 = int.Parse(Console.ReadLine());

            Console.Write("Give a second number: ");
            int Num2 = int.Parse(Console.ReadLine());
            Minimum(Num1, Num2);
            Console.ReadKey();
        }

        public static void Minimum(int Num1, int Num2)
        {
            if (Num1 < Num2)
            {
                Console.WriteLine("Smaller of the 2 numbers was " + Num1);
            }
            else
            {
                Console.WriteLine("Smaller of the 2 numbers was " + Num2);
            }

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_tasks_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 4
            Console.WriteLine("Write a palindrome: ");
            string something = Console.ReadLine();

            something = something.Replace(" ", "");

            bool pali = false;
            string reversed = new string(something.Reverse().ToArray());

            if (something == reversed)
            {
                pali = true;
            }
            else
            {
                pali = false;
            }

            if (pali == false)
            {
                Console.WriteLine("It is not a palindrome");
            }
            else
            {
                Console.WriteLine("It is a palindrome");
            }

            Console.ReadKey();
            /* alternate, does not work for multiple words or sentences!
             
            int length = something.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (something[i] != something[length - i - 1])
                {
                    pali = false;
                }
                else
                {
                    pali = true;
                }
            }*/
        }
    }
}

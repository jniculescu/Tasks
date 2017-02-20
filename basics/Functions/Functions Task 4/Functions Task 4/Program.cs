using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions_Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var answer = new int[10];

            Console.WriteLine("Give 10 numbers: ");

            for (int i = 0; i < 10; i++)
            {
                answer[i] = Parameters();

                Console.WriteLine(i + ". " + answer[i]);
            }

            Console.WriteLine("You entered the following numbers: ");
            Console.WriteLine(string.Join(" ", answer));

            int n = answer.Max();
            int index = Array.IndexOf(answer, n);
            Console.WriteLine("Largest number was the " + n + " at position " + (index + 1));

            Console.ReadKey();
        }

        static public int Parameters()
        {
            int answer = 0;
            do
            {
                answer = int.Parse(Console.ReadLine());

                if (answer < 0)
                {
                    Console.WriteLine("Invalid answer please enter again: ");
                }
            }
            while (answer < 0);
            return answer;
        }
    }
}

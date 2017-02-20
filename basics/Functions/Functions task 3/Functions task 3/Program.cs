using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions_task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int Answer = 0;
            Console.WriteLine("Give A number between 1 and 10: ");
            Answer = Parameters(Answer);

            Console.WriteLine("Annoit numeron " + Answer);
            Console.ReadKey();
        }

        static public int Parameters(int answer)
        {
            do
            {
                answer = int.Parse(Console.ReadLine());

                if (answer < 0 || answer > 10)
                {
                    Console.WriteLine("Invalid answer please enter again: ");
                }
            }
            while (answer < 0 || answer > 10);
            return answer;
        }
    }
}

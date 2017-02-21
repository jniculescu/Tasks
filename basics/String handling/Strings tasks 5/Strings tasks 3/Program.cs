using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_tasks_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //task 5

            Console.WriteLine("Write something: ");
            string something = Console.ReadLine().ToLower();
            var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u', 'ö', 'ä' , 'å'};
            int amount = 0;

            amount = something.Count(c => vowels.Contains(c));

            Console.WriteLine("Amount of vowels is: " + amount);
            Console.ReadKey();
        }
    }
}

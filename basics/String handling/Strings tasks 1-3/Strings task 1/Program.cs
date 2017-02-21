using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_task_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Write Something: ");
            string something =  Console.ReadLine();

            /* First part
            Console.WriteLine("What you wrote had " + something.Length + " characters.");*/

            /* Second part
            something = something.Replace("e", "@");
            Console.WriteLine(something);*/

            /* Third part
            int c = 0;

            for (int i = 0; i < something.Length; i++)
            {
                if (something[i].ToString().ToUpper() == "L")
                {
                    c++;
                }
            }
            Console.WriteLine("Letter L occurs " + c + " times in what you wrote.");*/

            Console.ReadKey();
        }
    }
}

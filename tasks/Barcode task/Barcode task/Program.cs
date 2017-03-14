using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barcode_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Barcode creator!");
            Console.WriteLine("Is your reference number in the international form? Y/N (RFXX XXXX XXXX....");

            string answer = Console.ReadLine();
            answer = answer.ToUpper();
            if (answer == "N")
            {
                Ver4 version4 = new Ver4();
                version4.IBAN();
            }
            else
            {
                Ver5 version5 = new Ver5();
                version5.IBAN();
            }

        }

        public void Error()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Error happened. Try again.");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}

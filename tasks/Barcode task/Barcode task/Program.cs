using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barcode_Task
{
    /*      alku ver IBAN eurot sentit varalle refnum ja eräpäivä tarkiste2 loppumrk
     * Ver 4 =  4 0x16 0x6 0x2 000 0x20 VVKKPP
        first check ref num if international. IBAN creator-->remove FI for barcode. get sum of payment. get refcode. get duedate.
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the  Barcode creator!");
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
        }
    }
}

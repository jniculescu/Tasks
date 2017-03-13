using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barcode_Task
{
    class CreateSum
    {

        public string Euros()
        {
            Console.WriteLine("Please give the amount of payment(XXXXXX,XX): ");
            Console.WriteLine("Euros: ");
            string euros = Console.ReadLine();         
            return euros;
        }

        public string Cents()
        {
            Console.WriteLine("Cents: ");
            string cents = Console.ReadLine();
            return cents;
        }
    }
}

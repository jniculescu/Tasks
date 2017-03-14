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
            if (euros.Length < 6)
            {
                for (int i = 1; euros.Length < 6; i++)
                {
                    euros = euros.Insert(0, "0");
                }
            }

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

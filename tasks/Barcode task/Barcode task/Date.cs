using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barcode_Task
{
    class Date
    {
        public string InsertDate()
        {
            Console.WriteLine("Please give the date of billing YYYYMMDD: ");
            string date = Console.ReadLine();
            return date;
        }

    }
}

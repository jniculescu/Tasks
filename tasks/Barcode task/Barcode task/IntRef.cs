using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barcode_Task
{
    class IntRef
    {
        public string refnumber;

        public void GetintRef()
        {
            Console.WriteLine("Please give the International Refrence number: ");
            refnumber = Console.ReadLine();
        }

        public void Fullvalidate()
        {
            string referencenum = refnumber.Replace("F", "15");
            referencenum = refnumber.Replace("R", "27");
            string startnums = referencenum.Substring(0, 6);
            string refchk = referencenum.Insert(refnumber.Length, startnums);
            refchk = refchk.Remove(0, 6);

            decimal numref = decimal.Parse(refchk);

            if (numref % 97 == 1)
            {
                Ver5 v5 = new Ver5();
                v5.GetDate();
            }
            else
            {
                Program prog = new Program();
                prog.Error();
            }
        }
    }
}

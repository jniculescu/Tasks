using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Int.Refnumber_App
{
    class CoreValidate
    {
        public int lastnum;
        public int sum;

        public bool Validating(string refnumber)
        {
            refnumber = refnumber.Remove(0, 4);
            string refnumbernospace = refnumber.Replace(" ", "");
            lastnum = refnumbernospace.Length - 1;
            string reftochk = refnumbernospace.Remove(lastnum);

            char[] refArray = reftochk.ToCharArray();
            int[] multipliers = { 1, 3, 7 };
            sum = 0;
            int y = 0;

            for (int i = 0; i < refArray.Length; i++)
            {
                if (y > 2)
                {
                    y = 0;
                }
                sum = sum + (multipliers[y] * int.Parse(refArray[i].ToString()));
                y++;
            }

            int chk = 10 * ((sum + 9) / 10);
            int diff = chk - sum;

            if (diff == int.Parse(refnumber[lastnum].ToString()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Fullvalidate(string refnumber)
        {
            var referencenum = refnumber;
            referencenum = refnumber.Replace("R", "27");
            referencenum = refnumber.Replace("F", "15");
            string startnums = referencenum.Substring(0, 6);
            string refchk = referencenum.Insert(refnumber.Length, startnums);
            refchk = refchk.Remove(0, 6);

            decimal numref = decimal.Parse(refchk);

            if (numref % 97 == 1)
            {
                return  refnumber + " - OK";
            }
            else
            {
                return refnumber + " - Error";
            }
        }

    }
}

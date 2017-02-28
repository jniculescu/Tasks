using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Reference_app
{
    class CoreValidate
    {
        public int lastnum;
        public int sum;

        public bool isChecklen(string refnumber)
        {

            bool err;
            string refnospace = refnumber.Replace(" ", "");
            bool result = !refnospace.Any(x => char.IsLetter(x));

            if (result == true)
            {
                if (refnospace.Length >= 4 && refnospace.Length <= 20)
                {

                    err = false;
                }

                else
                {
                    err = true;

                }
            }
            else
            {
                err = true;
            }
            return err;
        }

        public string Validating(string refnumber)
        {
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

            if (diff == int.Parse(refnumber[lastnum + 1].ToString()))
            {
                return refnumber + " - ok";
            }
            else
            {
                return refnumber + " - Invalid";
            }
        }
    }

}


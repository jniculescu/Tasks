using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBAN_calculator
{
    class Core
    {
        public string bban;
        public string iban;

        public void BBAN()
        {
            bban = bban.Replace("-", "");
            var bbanarr = bban.ToCharArray().Select(c => c.ToString()).ToArray();

            if (bbanarr[0] == "4" || bbanarr[0] == "5")
            {
                while (bban.Length <= 13)
                {
                    bban = bban.Insert(6, "0");
                }
            }

            else
            {
                while (bban.Length <= 13)
                {
                    bban = bban.Insert(5, "0");
                }
            }
        }

        public bool isBBAN2(bool FI) //ability to add countries if needed.
        {

            bool err = false;
            if (FI)
            {
                bban = bban.Insert(14, "FI00");
                bban = bban.Replace("FI", "1518");
            }
            else
            {
                err = true;
            }
            return err;
        }

        public void IBAN()
        {
            decimal numiban = decimal.Parse(bban);

            numiban = numiban % 97;
            var numchk = 98 - numiban;
            string chk;

            if (numchk >= 10)
            {
                chk = numchk.ToString();
            }
            else
            {
                chk = numchk.ToString();
                chk = chk.Insert(0, "0");
            }

            iban = bban;
            iban = iban.Remove(14);
            iban = iban.Insert(0, "FI" + chk);
        }

        public string RetriveIBAN()
        {

            return iban;
        }

    }
}




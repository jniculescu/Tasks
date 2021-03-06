﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Barcode_Task
{
    class GetIBAN
    {
        public string IBAN;
        public bool lengthOk;
        public bool IBANok;

        public void IBANchk()
        {
            Console.WriteLine("Please Give a valid IBAN number: ");
            IBAN = Console.ReadLine();
            ChkLen();
        }

        public void ChkLen()
        {
            if (IBAN.Length == 18)
            {
                ValidateIBAN();
            }
            else
            {
                Program prog = new Program();
                prog.Error();
            }
        }

        public void ValidateIBAN()
        {
            string IBANchk1 = IBAN;
            string IBANstrt = IBANchk1.Substring(0, 4);
            IBANchk1 = IBANchk1.Remove(0, 4);
            IBANchk1 = IBANchk1.Insert(IBANchk1.Length, IBANstrt);
            IBANchk1 = IBANchk1.Replace("FI", "1518");
            decimal IBANchk2 = decimal.Parse(IBANchk1);

            if (IBANchk2 % 97 == 1)
            {
                ReturnIBAN();
            }
            else
            {
                Program prog = new Program();
                prog.Error();
            }
        }
        public string ReturnIBAN()
        {            
               return IBAN;
        }
    }
}

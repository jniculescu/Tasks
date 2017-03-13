using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Barcode_Task
{
    class Ver4
    {
        public string iban2;
        public string euros;
        public string cents;
        public string refnum;
        public string date;
        public string verNum = "4";

        public void IBAN()
        {
            GetIBAN getIBAN = new GetIBAN();
            string iban = getIBAN.ReturnIBAN();
            iban2 = iban.Remove(0, 2);
            GetSum();
        }

        public void GetSum()
        {
            CreateSum Sum = new CreateSum();
            euros = Sum.Euros();
            cents = Sum.Cents();
            Refnum();
        }

        public void Refnum()
        {
            RefCheck refchk = new RefCheck();
            refnum = refchk.Validating();
            GetDate();
        }

        public void GetDate()
        {
            Date getdate = new Date();
            date = getdate.InsertDate();
            FormBarcode();
        }

        public void FormBarcode()
        {
            Console.WriteLine("=====================================");
            Console.WriteLine("Created barcode: ");
            Console.WriteLine("{0}{1}{2}{3}000{4}{5}", verNum, iban2, euros, cents, refnum, date);
            Console.ReadKey();
        }

    }
}

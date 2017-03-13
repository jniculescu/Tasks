using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Int.Refnumber_App
{
    class CoreCreate
    {
        public string result;

        public void Create(string input)
        {
            string chknumstart = input.Insert(input.Length, "271500");
            decimal numchk = decimal.Parse(chknumstart);

            decimal modref = numchk % 97;
            var chknum = (98 - modref).ToString();

            string initialresult = input.Insert(0, "RF");
            initialresult = initialresult.Insert(2, chknum);

            for (int i = 4; i < initialresult.Length; i+= 4)
            {
                initialresult = initialresult.Insert(i, " ");
                i++;
            }

            result = initialresult;
        }

        public string Results()
        {
            return result;
        }
    }
}

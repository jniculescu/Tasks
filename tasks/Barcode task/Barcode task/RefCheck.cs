using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barcode_Task
{
    class RefCheck
    {
        public string refnum;

        public void GiveRef()
        {
            Console.WriteLine("Please Give the non-International Refence Number: ");
            refnum = Console.ReadLine();
            CheckRef();
        }

        public void CheckRef()
        {

            string refnospace = refnum.Replace(" ", "");
            bool result = !refnospace.Any(x => char.IsLetter(x));
            var refarr = refnospace.ToCharArray().Select(c => c.ToString()).ToArray();

            if (refarr[0] != "0")
            {
                if (result == true)
                {
                    if (refnospace.Length >= 4 && refnospace.Length <= 20)
                    {

                        Validating();
                    }

                    else
                    {
                        Program prog = new Program();
                        prog.Error();

                    }
                }
            }
            else
            {
                Program prog = new Program();
                prog.Error();
            }
        }

        public void Validating()
        {
            string refnumbernospace = refnum.Replace(" ", "");
            var lastnum = refnumbernospace.Length - 1;
            string reftochk = refnumbernospace.Remove(lastnum);

            char[] refArray = reftochk.ToCharArray();
            int[] multipliers = { 1, 3, 7 };
            var sum = 0;
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

            if (diff == int.Parse(refnum[lastnum].ToString()))
            {
                Sendref();
            }
            else
            {
                Program prog = new Program();
                prog.Error();

            }
        }

        public string Sendref()
        {
            return refnum;
        }
    }
}


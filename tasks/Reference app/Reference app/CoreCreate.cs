using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reference_app
{
    class CoreCreate
    {
        private Creator create;
        private CoreValidate valid;
        public string result;

        public bool Check(string refnum)
        {
            valid = new CoreValidate();
            bool err = false;

            if (valid.isChecklen(refnum) == true)
            {
                err = false;
            }
            else
            {
                err = true;
            }
            return err;
        }

        public void Create(string input, string amoun)
        {
            int[] multipliers = { 1, 3, 7 };
            int sum = 0;
            int mult = 0;
            int amount = int.Parse(amoun);

            char[] inputArr = input.ToCharArray();
            List<string> numbers = new List<string>();

            for (int i = 0; i < inputArr.Length; i++)
            {
                if (mult > 2)
                {
                    mult = 0;
                }
                sum = sum + (multipliers[mult] * int.Parse(inputArr[i].ToString()));
                mult++;
            }

            int chk = 10 * ((sum + 9) / 10);
            int diff = chk - sum;

            result = input.Insert(input.Length, diff.ToString());

            if (amount > 1)
            {
                /*
                numbers.Add();



                for (int i = input[input.Length]; i <= amount; i++)
                {
                    var replace = i.ToString().ToChar();
                    input.Replace(input.Length, replace);
                }*/
            }


        }
        public string Results()
        {
            return result;
        }
    }
}

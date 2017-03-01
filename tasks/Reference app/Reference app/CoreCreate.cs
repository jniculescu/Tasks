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
        public string result;
        public int[] multipliers = { 1, 3, 7 };
        public int sum = 0;
        public int mult = 0;
        public int amount;
        public string refnumbernospace;
        public char[] inputArr;
        public List<string> numbers;
        private int replacenum;
        private int placement;

        public bool Check(string refnum)
        {
            bool err;
            string refnospace = refnum.Replace(" ", "");
            bool result = !refnospace.Any(x => char.IsLetter(x));
            if (result == false)
            {
                if (refnospace.Length >= 4 && refnospace.Length <= 19)
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

        public void Create(string input)
        {
            sum = 0;
            mult = 0;
            refnumbernospace = input.Replace(" ", "");
            inputArr = refnumbernospace.ToCharArray();

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
        }

        public string Results()
        {
            return result;
        }

        public void MultipleRefs(string input, string amoun)
        {
            numbers = new List<string>();
            amount = int.Parse(amoun);

            replacenum = int.Parse((inputArr[refnumbernospace.Length - 1]).ToString());

            placement = int.Parse(inputArr[refnumbernospace.Length - 1].ToString());
            //placement = placement - 1;
            for (int i = 1; i <= amount; i++)
            {
                input = input.Insert(placement, replacenum.ToString());
                replacenum = replacenum + 1;
                input = input.Remove((placement + 1));

                for (int k = 0; k < inputArr.Length; k++)
                {
                    if (mult > 2)
                    {
                        mult = 0;
                    }
                    sum = sum + (multipliers[mult] * int.Parse(inputArr[k].ToString()));
                    mult++;
                }

                int chk = 10 * ((sum + 9) / 10);
                int difference = chk - sum;
                input = input.Insert(input.Length, difference.ToString());
                numbers.Add(input);
            }
        }

        public string Sendlist()
        {
            return String.Join(", ", numbers);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Int.Refnumber_App
{
    class Lengthchk
    {

        public bool isChecklenvalid(string refnumber)
        {
            bool err;
            string fiRefnumber = refnumber.Remove(0, 4);
            string fiRefnospace = fiRefnumber.Replace(" ", "");
            bool result = !fiRefnospace.Any(x => char.IsLetter(x));
            var refarr = fiRefnospace.ToCharArray().Select(c => c.ToString()).ToArray();

            if (refarr[0] == "0")
            {
                err = true;
            }

            else
            {

                if (result == true)
                {
                    if (fiRefnospace.Length >= 4 && fiRefnospace.Length <= 20)
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
            }
            return err;
        }

        public bool isChecklencreate(string refnumber)
        {
            bool err;
            string fiRefnumber = refnumber;
            string fiRefnospace = fiRefnumber.Replace(" ", "");
            bool result = !fiRefnospace.Any(x => char.IsLetter(x));
            var refarr = fiRefnospace.ToCharArray().Select(c => c.ToString()).ToArray();

            if (refarr[0] == "0")
            {
                err = true;
            }

            else
            {

                if (result == true)
                {
                    if (fiRefnospace.Length >= 4 && fiRefnospace.Length <= 19)
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
            }
            return err;
        }
    }
}

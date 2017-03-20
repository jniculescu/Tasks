using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ski_jumpTask
{
    class Windeffect
    {
       // windage= wind strength average(5 wind measuring points) * (k-point - 36)/20. rounded to 0,5 increments.points amount is 1.8x rounded sum.

        Random rnd = new Random();

        public void Wind()
        {
            string windage1 = rnd.Next(1, 2) + "," + rnd.Next(0, 9);
            string windage2 = rnd.Next(1, 2) + "," + rnd.Next(0, 9);
            string windage3 = rnd.Next(1, 2) + "," + rnd.Next(0, 9);
            string windage4 = rnd.Next(1, 2) + "," + rnd.Next(0, 9);
            string windage5 = rnd.Next(1, 2) + "," + rnd.Next(0, 9);

            float windAverage = (float.Parse(windage1) + float.Parse(windage2) + float.Parse(windage3) + float.Parse(windage4) + float.Parse(windage5))/5;


        }

    }
}

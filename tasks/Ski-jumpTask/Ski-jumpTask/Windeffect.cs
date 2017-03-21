using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ski_jumpTask
{
    class Windeffect
    {
       // windage= wind strength * (k-point - 36)/20. rounded to 0,5 increments.points amount is 1.8x rounded sum.

        public double windCorrection;
        public double wind;

        public void HeadorTail(Jumpers jumpers, Jumper jump)
        {
            wind = double.Parse(jumpers.wind[jump.i]);
            if (wind > 0)
            {
                HeadWind(jumpers);
            }
            else
            {
                TailWind(jumpers);
            }
        }

        public void HeadWind(Jumpers jumpers)
        {

            var windA = wind * (jumpers.criticalPoint - 36) / 20;

            var windRounded = windA % 0.5 == 0 ? 1 : 0;
            var what = Math.Round(windA, windRounded);
            windCorrection = what * 1.8;

        }

        public void TailWind(Jumpers jumpers)
        {

            var windB = wind * (jumpers.criticalPoint - 36) / 20;

            var windRounded = windB % 0.5 == 0 ? 1 : 0;
            var what = Math.Round(windB, windRounded);
            windCorrection = what * 1.8;

        }

    }
}

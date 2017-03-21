using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ski_jumpTask
{
    class Jumpdistance
    {


        Random rnd = new Random();
        public int distance;

        public void CalcDistance(SumPoints sumPoints, Jumper jump, Jumpers jumpers)
        {

            int minDist = sumPoints.criticalPoint - 20;
            int maxDist = sumPoints.criticalPoint + 20;

            distance = rnd.Next(minDist, maxDist);
            if (jump.jumperAmount > 1)
            {
                if (jumpers.platform[jump.i - 1] != jumpers.platform[jump.i - 2])
                {
                    Startplatform start = new Startplatform();
                    start.Platform(jumpers, jump);
                    distance = distance + start.distCorrection;
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ski_jumpTask
{
    class Startplatform
    {
        //starting point = 1m +- = 5m jump distance.  example 1.4m above the last entrant = 1,4x5m = 7m.

        public int distCorrection;
        public int platform1;
        public int platform2;

        public void Platform(Jumpers jumpers, Jumper jump)
        {
            //default platform is 2 and increments are 1M per platform
            platform1 = int.Parse(jumpers.platform[jump.i - 1]);
            platform2 = int.Parse(jumpers.platform[jump.i - 2]);

            distCorrection = (platform1 - platform2) * 5;

        }
    }
}

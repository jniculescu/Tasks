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
        //need to be rethinked how to deliver this part of the task===========not final for now.

        Random rnd = new Random();
        public int distCorrection;

        public void Platform()
        {
          /*  //5 platforms used by random, they are 1 meter apart => plat 1 = 1m, plat 2 = 2m.....
            int platform = rnd.Next(1, 5);

            distCorrection = platform * 5;
            */
            distCorrection = 0;

        }
    }
}

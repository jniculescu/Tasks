using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ski_jumpTask
{
    class Jumpdistance
    {
        MainWindow main = new MainWindow();
        Startplatform start = new Startplatform();
        Random rnd = new Random();
        public int distance;

        public void CalcDistance()
        {
            int minDist = main.criticalPoint - 20;
            int maxDist = main.criticalPoint + 20;

            distance = rnd.Next(minDist, maxDist) + start.distCorrection;

        }

    }
}

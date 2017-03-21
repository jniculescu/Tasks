using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ski_jumpTask
{

    //    stylepoints = max 20 per judge, highest and lowest gets removed. so max is 60.
    class StylePoints
    {

        Random rnd = new Random();
        public int pointsStyle;

        public void Stylepoints()
        {
            var judge1 = rnd.Next(0, 20);
            var judge2 = rnd.Next(0, 20);
            var judge3 = rnd.Next(0, 20);
            var judge4 = rnd.Next(0, 20);
            var judge5 = rnd.Next(0, 20);

            var judges = new[] {judge1, judge2, judge3, judge4, judge5};

            var max = judges.Max();
            var min = judges.Min();

            pointsStyle = judges.Sum() - (min + max);

        }

    }
}

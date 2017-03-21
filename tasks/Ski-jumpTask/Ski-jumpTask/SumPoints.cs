using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ski_jumpTask
{
    class SumPoints
    {
        public float distMultip;
        public int criticalPoint;
        public int pointsCpoint;
        public float windageMultp;

        public string points;
        public float distancePoints;
        public double windPoints;
        public float stylePoints;
        public int distance;

        public void GetPoints(Jumpers jmpers, Jumper jump)
        {
            distMultip = jmpers.distMultip;
            criticalPoint = jmpers.criticalPoint;
            pointsCpoint = jmpers.pointsCpoint;
            windageMultp = jmpers.windageMultp;
            JumpPoints(jmpers, jump);
        }

        public void JumpPoints(Jumpers jumpers, Jumper jump)
        {
            Jumpdistance dist = new Jumpdistance();
            dist.CalcDistance(this, jump, jumpers);

            distance = dist.distance;
            if (distance == criticalPoint)
            {
                distancePoints = pointsCpoint;
            }
            else if (distance < criticalPoint)
            {
                distancePoints = pointsCpoint - ((criticalPoint - distance) * distMultip);
            }

            else
            {
                distancePoints = pointsCpoint + ((distance - criticalPoint) * distMultip);
            }

            Windage(jumpers, jump);
        }

        public void Windage(Jumpers jumpers, Jumper jump)
        {
            Windeffect wind = new Windeffect();
            wind.HeadorTail(jumpers, jump);
            windPoints = wind.windCorrection;
            Style();
        }

        public void Style()
        {
            StylePoints sPoints = new StylePoints();
            sPoints.Stylepoints();
            stylePoints = sPoints.pointsStyle;
            Sum();
        }

        public void Sum()
        {
            points = (distancePoints + windPoints + stylePoints).ToString();
        }
    }
}

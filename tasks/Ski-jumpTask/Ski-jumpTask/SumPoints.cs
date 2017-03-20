using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ski_jumpTask
{
    class SumPoints
    {
        MainWindow main = new MainWindow();
        
        public string points;
        public float  distancePoints;

        public void GetPoints()
        {
            JumpPoints();
        }

        public void JumpPoints()
        {
            Jumpdistance dist = new Jumpdistance();

            int distance = dist.distance;
            if (distance == main.criticalPoint)
            {
                distancePoints = main.pointsCpoint;
            }
            else if (distance < main.criticalPoint)
            {
                distancePoints = main.pointsCpoint - ((main.criticalPoint - distance) * main.distMultip);
            }
             
            else
            {
                distancePoints = main.pointsCpoint + ((distance - main.criticalPoint) * main.distMultip);
            }

            Windage();
        }

        public void Windage()
        {
            
        }

        public void StylePoints()
        {
            
        }

        public void Sum()
        {
            


        }


    }
}

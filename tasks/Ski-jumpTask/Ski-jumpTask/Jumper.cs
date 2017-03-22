using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ski_jumpTask
{
    class Jumper
    {
        public List<string> Contestants;
        public int i;
        public int jumperAmount;

        public void AddJumper(Jumpers jmpers)
        {
            Contestants = new List<string>();

            SumPoints sumPoints = new SumPoints();

            jumperAmount = int.Parse(jmpers.txtAmount.Text);

            for (i = 1; i <= jumperAmount; i++)
            {
                sumPoints.GetPoints(jmpers, this);
                string points = sumPoints.points;
                string distance = sumPoints.distance.ToString();

                string complete = "Jumper: " + jmpers.names[i - 1] + "\nPoints: " + points + "\nDistance: " + distance + "M";
                Contestants.Add(complete);
            }
            Send(jmpers);
        }

        public void Send(Jumpers jumpers)
        {
            string results = string.Join("\n", Contestants.ToArray());
            jumpers.txtResults.Text = results;
        }
    }
}

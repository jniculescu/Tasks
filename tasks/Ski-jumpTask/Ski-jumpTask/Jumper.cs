using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ski_jumpTask
{
    class Jumper
    {
        public List<string> Jumpers;

        public void AddJumper()
        {
            Jumpers jmpers = new Jumpers();
            SumPoints sumPoints = new SumPoints();

            int jumperAmount = int.Parse(jmpers.txtAmount.Text);

            for (int i = 1; i < jumperAmount; i++)
            {
                jmpers.lblJumpernum.Content = i ;
                string name = jmpers.txtInput.Text;
                sumPoints.GetPoints();
                string points = sumPoints.points;

                string complete = "Jumper: " + name + "\n Points: " + points;
                Jumpers.Add(complete);

            }

        }
    }
}

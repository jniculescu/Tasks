using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    class Program
    {
        static void Main(string[] args)
        {
            Car mycar = new Car();
            Car mycar2 = new Car("VW", 90);
            mycar2.Speed = 100;
            string mrk = mycar2.Make;

            Console.WriteLine(mycar.RetrieveData());
            Console.WriteLine(mycar2.RetrieveData());
        }
    }
}

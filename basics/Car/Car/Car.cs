using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    class Car
    {
        private string make;
        private float speed;

        //Default constructor
        public Car()
        {
            make = "Ford";
            speed = 80F;
        }

        //Constructor with parameters
        public Car(string Make, float Speed)
        {
            this.make = Make;
            this.speed = Speed;
        }
        //properties
        public float Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        public string Make
        {
            get { return make; }
            set { make = value; }
        }

        //  metodit
        public string RetrieveData()
        {
            return make + " " + speed;
            //string.Format("Merkki: {0}\nNopeus: {1} km/h");
        }
    }
}

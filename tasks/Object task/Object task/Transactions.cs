using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_task
{
    class Transactions
    {

        private string _date;
        private float _amount;


        public TransactionActivity(string date, float amount)
        {
            this._date = date;
            this._amount = amount;
        }

        public string Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public float Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }
    }
}

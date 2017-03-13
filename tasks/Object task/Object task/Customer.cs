using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_task
{
    class Customer
    {
        private string _frstname;
        private string _lstname;
        private string _accountnum;

        public Customer(string firstName, string lastName)
        {
            _frstname = firstName;
            _lstname = lastName;
        }

        public string BankAccNum
        {
            get { return _accountnum;}
            set { _accountnum = value; }
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", _frstname, _lstname);
        }
    }
}

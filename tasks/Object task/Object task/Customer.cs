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
        private string _accnum;

        public string FirstName
        {
            get { return _frstname; }
            set { _frstname = value; }
        }
        public string LastName
        {
            get { return _lstname; }
            set { _lstname = value; }
        }
        public string AccountNumber
        {
            get { return _accnum; }
        }

        public Customer(string firstName, string lastName, string accountNumber)
        {
            _frstname = firstName;
            _lstname = lastName;
            _accnum = accountNumber;
        }
        public override string ToString()
        {
            return string.Format("{0} {1}\t({2})", _frstname, _lstname, _accnum);
        }
    }
}

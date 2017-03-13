using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_task
{
    class BankAccount
    {
        private string _accountNumber;
        private string _creationDate;
        private List<Transactions> _transactions;
        private double _balance;

        public Account(string accountNumber, string creationDate)
        {
            this._accountNumber = accountNumber;
            this._creationDate = creationDate;
            _transactions = new List<Transactions>();
            _balance = 0.0;
        }

        public List<Transactions> Transactions
        {
            get
            {
                return (from transaction in _transactions
                    orderby transaction.Date
                    select transaction).ToList();
            }
        }

        public string AccNum
        {
            get { return _accountNumber; }
            set { _accountNumber = value; }
        }

        public double Balance
        {
            get { return _balance; }
        }

        public string CreationDate
        {
            get { return _creationDate; }
            set { _creationDate = value; }
        }








        public List<Transactions> GetTransactionsForTimeSpan(DateTime startTime, DateTime endTime)
        {
            List<Transactions> res = (from transaction in _transactions
                where transaction.TimeStamp >= startTime && transaction.TimeStamp <= endTime
                orderby transaction.TimeStamp
                select transaction).ToList();
            return res;
        }

        public bool AddTransaction(Transactions transaction)
        {
            bool res = false;
            _transactions.Add(transaction);
            double balanceBeforeTransaction = _balance;
            if (_transactions.Last().Equals(transaction))
            {
                _balance += transaction.Sum;
            }
            if (_balance - transaction.Sum == balanceBeforeTransaction)
            {
                res = true;
            }
            return res;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_task
{
    class Bank
    {
        private string _name;
        private List<BankAccount> _bankAccounts;

        public Bank(string name)
        {
            this._name = name;
            this._bankAccounts = new List<BankAccount>();
        }

        public string NewAccount()
        {
            Random rnd = new Random();
            decimal ibanpart1 = rnd.Next(1000000000);
            decimal ibanpart2 = rnd.Next(100000);

            var bankAccNum = "FI" + ibanpart1 + ibanpart2;
            for (int i = 4; i < bankAccNum.Length; i += 4)
            {
                bankAccNum = bankAccNum.Insert(i, " ");
                i++;
            }
            Console.WriteLine("New IBAN for customer: " + bankAccNum);

            string day = rnd.Next(1, 29).ToString();
            string month = rnd.Next(1, 12).ToString();
            string year = rnd.Next(2016, 2018).ToString();

            var accCreationDate =  day + "/" + month + "/" + year;

            _bankAccounts.Add(new Account(bankAccNum, accCreationDate));
            return bankAccNum;
        }

        public BankAccount GetBankAccount(string accountNumber)
        {
            return _bankAccounts.Find(x => x.AccNum.Equals(accountNumber));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_task
{
    class Customer
    {
        public string[] _frstname;
        public string[] _lstname;
        public string[] _bnknum;

        void Person()
        {
            Bank bank = new Bank();

            for (int i = 0; i < 3; i++)
            {
                _frstname[i] = Console.ReadLine();
                _lstname[i] = Console.ReadLine();
                _bnknum[i] = bank._bnknum[i]; 


            }
          //  Console.WriteLine(_frstname[] + " " + _lstname[] + " " + _bnknum[]);
        }

    }
}

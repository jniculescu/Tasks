using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bank App Ver. 0.0.1");
            Console.WriteLine("Enter the name of your bank: ");
            string bankName = Console.ReadLine();
            Bank bank = new Bank(bankName);

            Console.WriteLine("Number of customers: ");
            int numcustomers = Console.Read();
            List<Customer> customers = new List<Customer>();

            for (int i = 1; i < numcustomers; i++)
            {
                Console.WriteLine("Give info of customer #" + i);
                Console.Write("Lastname :");
                string lastname = Console.ReadLine();
                Console.Write("Firstname :");
                string firstname = Console.ReadLine();

                var customer = new Customer(firstname, lastname);
                customer.BankAccNum = bank.NewAccount();
                customers.Add(customer);

                AddTransactions(bank, customer);
            }

            foreach (var customer in customers)
            {
                Console.WriteLine("Customer: {0}, account:{1}, balance:{2:F2}",
                    customer, customer.BankAccNum, bank.SendNumber(customer.BankAccNum).Balance);
            }
            Console.WriteLine("---------------------------------");


        }

        static void AddTransactions(Bank bank, Customer customer)
        {
            Console.WriteLine("Give amount of withdawal or deposit from customer {0}", customer);
            var account = bank.GetBankAccount(customer.BankAccNum);
            var activityDate = account.Date

        }
    }
}

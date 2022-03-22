using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement
{
    public delegate void checkBalance(String msg);

    class Account
    {
        public long accountNumber;
        public String accountHolderName;
        public double balance;
        public event checkBalance eventZero;

        public void handleEvent(String msg)
        {
            Console.WriteLine(msg);
        }
        public Account(long accountNumber, String accountHolderName, double balance)
        {
            this.accountNumber = accountNumber;
            this.accountHolderName = accountHolderName;
            this.balance = balance;
        }
        public void Withdraw(double amount)
        {
            balance = balance - amount;
            if (balance == 0)
            {
                eventZero("Amount is Zero");
            }
            else if (balance <= 10000)
            {

                eventZero("Balance is below 10000");
            }
            else
            {
                Console.WriteLine("Balance is:" + balance);
            }
        }

        public void Deposit(double amount)
        {
            balance = balance + amount;
            if (balance <= 10000)
            {
                /*this.eventZero += new checkBalance(this.handleEvent);*/
                 eventZero("Balance is below 10000");
            }
            else
            {
                Console.WriteLine("Balance is:" + balance);
            }
        }

        public static void Main()
        {
            Account a = new Account(100, "Sayan", 20000);
            a.eventZero += new checkBalance(a.handleEvent);
            a.Withdraw(6000);
            Console.ReadKey();
        }
    }
}

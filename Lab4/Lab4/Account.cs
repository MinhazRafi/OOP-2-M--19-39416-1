using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Account
    {
        private String accName;
        public String AccName
        {
            get { return accName; }
            set { accName = value; }
        }
         private String acid;
        public String AccId
        {
            get { return acid; }
            set { acid = value; }
        }
        private int balance;
        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public void Deposit(int amount)
        {
            if (amount > 0)
            {
                this.balance += amount;
                Console.WriteLine("Balance after deposit:" + this.balance);
            }

        }
        public void Withdraw(int amount)
        {
            if (amount < balance)
            {
                this.balance -= amount;
                Console.WriteLine("Balance after withdraw:" + this.balance);
            }
            else
            {
                Console.WriteLine("Insufficient balance");
            }

        }
        public void Transfer(int amount, Account acc)
        {
            acc.balance = acc.balance + amount;
            this.balance = this.balance - amount;
        }
    }
}


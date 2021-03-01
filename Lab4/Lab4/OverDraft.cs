using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class OverDraft : Account
    {
        private int limit;
        public int Limit
        {
            get { return limit; }
            set { limit = value; }
        }
        public OverDraft(String accName, String acid, int limit, int balance)
        {
            this.AccName = accName;
            this.AccId = acid;
            this.limit = limit;
            this.Balance = balance;
        }
        public void Withdraw(int amount, int limit)
        {
            if (amount < (limit + Balance))
            {
                if (amount < Balance)
                {
                    this.Balance -= amount;
                    Console.WriteLine("Balance after withdraw:" + this.Balance);
                }
                else
                {
                    int val = (Balance + limit) - amount;
                    Console.WriteLine("Your bank account is null");
                }
            }

        }
    }
}

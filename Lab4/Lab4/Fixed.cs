using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Fixed : Account
    {
        private int tenureYear;
        public int TenureYear
        {
            get { return tenureYear; }
            set { tenureYear = value; }
        }
        private int currrentYear;
        public int CurrrentYear
        {
            get { return currrentYear; }
            set { currrentYear = value; }
        }
        public Fixed(String accName, String acid, int balance, int tenureYear, int currrentYear)
        {
            this.AccName = accName;
            this.AccId = acid;
            this.Balance = balance;
            this.tenureYear = tenureYear;
            this.currrentYear = currrentYear;
        }
        public void Withdraw(int currrentYear, int tenureYear, int amount)
        {
            if (tenureYear < currrentYear)
            {
                if (amount < Balance)
                {
                    this.Balance -= amount;
                    Console.WriteLine("Balance after withdraw:" + this.Balance);
                }
                else
                {
                    Console.WriteLine("Insufficient balance");
                }
            }

        }
    }
 }


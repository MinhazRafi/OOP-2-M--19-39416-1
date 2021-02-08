using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_1_
{
    public class Account
    {
        String accName;
        String acid;
        int balance;

        public Account(String accName, String acid, int balance)
       {
           this.accName = accName;
           this.acid = acid;
           this.balance = balance;
       }
        public String AccName
        {
            set { accName = value; }
            get { return accName; }
        }
        public String Acid
        {
            set { acid = value; }
            get { return acid; }
        }
        public int Balance
        {
            set { balance = value; }
            get { return balance; }
        }
        public void ShowInfo()
        {

            Console.WriteLine("\naccount name : " +accName );
            Console.WriteLine("account id : " + acid);
            Console.WriteLine("balance : " + balance);
        
        }
       public void Deposit(int amount)
        {
            balance = balance + amount;
            Console.WriteLine("Your new deposit is : "+balance);
            

        }
       public void Withdraw(int amount)
       {
           balance = balance - amount;
           Console.WriteLine("Your new withdraw is : "+balance);
           

       }
    }
}

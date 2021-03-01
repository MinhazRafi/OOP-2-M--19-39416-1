using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Account();
            a1.AccName = "Rafi";
            a1.AccId = "22111123";
            a1.Balance = 9000;
            Console.WriteLine("Account Name is :" + a1.AccName);
            Console.WriteLine("Account ID is :" + a1.AccId);
            Console.WriteLine("Account Balance :" + a1.Balance);

            Savings s1 = new Savings(a1.AccName, a1.AccId, a1.Balance, 500);
            s1.Withdraw(6000, 500);
            Console.WriteLine("Savings account current Balance :" + s1.Balance);

            SpecialCurrent sc1 = new SpecialCurrent(a1.AccName, a1.AccId, a1.Balance, 2500);
            sc1.Withdraw(7000, 2500);
            Console.WriteLine("SpecialCurrent account Balance :" + sc1.Balance);

            Fixed f1 = new Fixed(a1.AccName, a1.AccId, a1.Balance, 12, 9);
            f1.Withdraw(10, 8, 550);
            Console.WriteLine("Fixed account current Balance :" + f1.Balance);

            OverDraft od1 = new OverDraft(a1.AccName, a1.AccId, a1.Balance, 50000);
            od1.Withdraw(5000, 50000);
            Console.WriteLine("");
            Account a2 = new Account();
            a2.AccName = "Minhaz";
            a2.AccId = "2231989";
            a2.Balance = 8500;
            Console.WriteLine("Account Name is :" + a2.AccName);
            Console.WriteLine("Account ID is :" + a2.AccId);
            Console.WriteLine("Account Balance :" + a2.Balance);
            Savings s2 = new Savings(a2.AccName, a2.AccId, a2.Balance, 500);
            s2.Withdraw(6000, 500);
            Console.WriteLine("Savings account current Balance :" + s1.Balance);

            SpecialCurrent sc2 = new SpecialCurrent(a2.AccName, a2.AccId, a2.Balance, 2500);
            sc2.Withdraw(7000, 2500);
            Console.WriteLine("SpecialCurrent account Balance :" + sc2.Balance);

            Fixed f2 = new Fixed(a2.AccName, a2.AccId, a2.Balance, 12, 9);
            f2.Withdraw(10, 8, 550);
            Console.WriteLine("Fixed account current Balance :" + f2.Balance);

            OverDraft od2 = new OverDraft(a2.AccName, a2.AccId, a2.Balance, 50000);
            od2.Withdraw(7000, 70000);
            Console.WriteLine("");
            
        }
        }
 }


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account();

            //Console.WriteLine("performing Account Transactions using ACcount MAnager 1 ");
            //AccountManager1 Acc1 = new AccountManager1();
            //Acc1.FillAccountData(acc);
            //Acc1.DisplayAccountData(acc);


            //Console.WriteLine();

            Console.WriteLine("performing Account Transactions using Account Manager 2");
            AccountManager2 Acc2 = new AccountManager2();
            Acc2.FillAccountData(acc);
            Acc2.DisplayAccountData(acc);

            Console.ReadLine();
        }
    }
}

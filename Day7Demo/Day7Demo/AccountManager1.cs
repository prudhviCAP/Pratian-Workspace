using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Demo
{
    class AccountManager1
    {
        /// <summary>
        /// method to give account details
        /// 
        /// Name : FillAccountData
        /// Parameters : Account
        /// return type : void
        /// </summary>
        /// <param name="Acc"></param>
        public void FillAccountData(Account Acc)
        {
            Acc._AccNo = "004701";
            Acc._Name = "Chandra";
            Acc._Balance = 45000.0;
        }

        /// <summary>
        /// Method to display account details
        /// 
        /// Name : DisplayAccountData
        /// Parameters : Account
        /// output : To console
        /// return type : void
        /// </summary>
        /// <param name="Acc"></param>
        public void DisplayAccountData(Account Acc)
        {
            Console.WriteLine(" Account Number : " + Acc._AccNo);
            Console.WriteLine(" Customer Name : " + Acc._Name);
            Console.WriteLine(" Account Balance : " + Acc._Balance);
        }
    }
}

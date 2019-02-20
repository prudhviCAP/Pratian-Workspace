
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Demo
{
    class Account
    {
        internal string _AccNo;
        internal string _Name;
        internal double _Balance;

        public string AccNo
        {
            get
            {
                return _AccNo;
            }
            set
            {
                string BankCode = "ICI";
                _AccNo = BankCode + value;
            }
        }
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = "Mr."+value;
            }
        }
        public double Balance
        {
            get
            {
                return _Balance+ComputeInterest();
            }
            set
            {
                _Balance = value;
            }
        }
        /// <summary>
        /// Method to calculate interest for an account
        /// Variable  :  Interest, _Balance
        /// </summary>
        /// <returns>Interest</returns>
        double ComputeInterest()
        {
            double Interest = _Balance * 8.5 / 100.0;
            return Interest;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBankManagement
{
    internal class Account
    {
        private string _accountNumber;
        private string _accountHoldername;
        private decimal _balance;

        public Account(string accountnumber,string accountholdername,decimal initialbalance)

        {
            _accountNumber = accountnumber;
            _accountHoldername = accountholdername;
            _balance = initialbalance;
        }

        public string AccountNumber
        {
            get { return _accountNumber; }
            set { _accountNumber = value; }
        }
        public string AccountHoldername
        {
            get { return _accountHoldername; }
            set { _accountHoldername = value; }
        }
        public decimal Balance
        {
            get { return _balance; } 
            set { _balance = value; }
        }
        public void Deposit(decimal amount)
        {
            if(amount > 0)
            {
                _balance += amount;

            }
        }
        public bool Withdraw(decimal amount)
        {
            if(amount>0&&amount<=_balance)
            {
                _balance -= amount;
                return true;
            }
            return false;
        }
    }
}

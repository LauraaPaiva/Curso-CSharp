using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using E155.Exceptions;

namespace E155.Entities
{
    internal class Account
    {
        public int Number { get; set; }
        public String Holder { get; set; }
        public Double Balance { get; set; }
        public Double WithdrawLimit { get; set; }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double depositValue)
        {
            Balance += depositValue;
        }

        public void Withdraw(double withdrawValue)
        {
            if (WithdrawLimit < withdrawValue)
            {
                throw new DomainException("The amount exceeds withdraw limit");
            }
            else if (Balance - withdrawValue < 0)
            {
                throw new DomainException("Not enough balance");
            }
            else
            {
                Balance -= withdrawValue;
            }                
        }
    }
}

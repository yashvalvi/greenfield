﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeatureApp
{
    public  class Account
    {
        public event Operation underBalance;
        public event Operation overBalance;
        public double Balance { get; set; }
        public Account(double initialAmount)
        {
            Balance = initialAmount;
        }
        public void Withdraw(double amount)
        {
            double result=Balance-amount;
            if (result <= 10000)
            {
                //raise an event:underbalance
                underBalance(5);
            }
            Balance = result;
        }
        public void Deposit(double amount) {
            Balance += amount;
            if (Balance >= 25000)
            {
                //raise an event:overbalance
                overBalance(10);
            }
        }
    }
}

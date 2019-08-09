using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyBankingApp
{
    public class Transaction
    {
        private string accountName;
        private DateTime Date;
        private decimal Amount;
        private string Type;
        private decimal CurrentBalance;

        public Transaction(string name, DateTime date, decimal amount, string type, decimal balance)
        {
            accountName = name;
            Date = date;
            Amount = amount;
            Type = type;

            CurrentBalance = balance;
        }

        public decimal amount
        {
            get
            {
               return Amount;
            }

            set
            {
                Amount = value;
            }
        }

        public DateTime date
        {
            get
            {
                return Date;
            }

            set
            {
                Date = value;
            }
        }

        public string accountname
        {
            get
            {
               return accountName;
            }

            set
            {
                accountName = value;
            }
        }

        public string type
        {
            get
            {
               return Type;
            }

            set
            {
                Type = value;
            }
        }

        public decimal currentBalance
        {
            get
            {
                return CurrentBalance;
            }

            set
            {
                CurrentBalance = value;
            }
        }

        public override string ToString()
        {
            return string.Format("DATE: {0}  ACCOUNT: {1}  TRANSACTION TYPE: {2}  AMOUNT: {3}  BALANCE: {4}", 
                Date.ToShortDateString(), accountName, Type, amount.ToString("c"), currentBalance.ToString("c2"));
        }
    }
}
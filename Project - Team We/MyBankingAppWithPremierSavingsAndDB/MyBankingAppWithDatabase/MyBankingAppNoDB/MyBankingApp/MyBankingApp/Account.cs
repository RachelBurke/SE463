using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyBankingApp
{
    public class Account
    {
        private decimal Balance;
        private string Name;
        private Boolean LowBalanceApplied = false;

        private List<Transaction> Transactions;

        const decimal PREMIER_SAVINGS_INTEREST_RATE = 0.065m;
        const decimal PREMIER_SAVINGS_LOW_BALANCE_LIMIT = 1000m;
        const decimal PREMIER_SAVINGS_LOW_BALANCE_FEE = 50m;
        public Account(decimal balance, string name)
        {
            Balance=balance;
            Name = name;

            Transactions = new List<Transaction>();
        }

        public decimal balance
        {
            get
            {
                return Balance;
            }

            set
            {
                Balance = value;
            }
        }

        public string name
        {
            get
            {
                return Name;
            }

            set
            {
                Name = value;
            }
        }

        public List<Transaction> transactions
        {
            get
            {
                return Transactions;
            }
            set
            {
                Transactions = value;
            }

        }

        public string Deposit(decimal amount)
        {
            Balance += amount;

            if (Name == "PremierSavings" && Balance >= PREMIER_SAVINGS_LOW_BALANCE_LIMIT )
            {
                LowBalanceApplied = false;
            }

            Transaction newTrans = new Transaction(Name, DateTime.Today,amount,"Deposit",Balance);

            Transactions.Add(newTrans);

            return "Amount of " + amount + " dollars was deposited in the " + Name + " account.";
        }

        public string Withdraw(decimal amount)
        {
            string message = string.Empty;

            if (amount <= Balance)
            {
                Balance -= amount;

                message = AddLowBalanceFee();

                Transaction newTrans = new Transaction(Name, DateTime.Today, amount, "Withdraw", Balance);

                Transactions.Add(newTrans);

                message += "Amount of " + amount + " dollars was withdrawn from the " + Name + " account.";
            }
            else
            {
                message = "Insufficient Funds!";
            }
            return message;
        }

        public string Transfer(decimal amount, ref Account destinationAccount)
        {
            string message = string.Empty;

            if (Balance >= amount)
            {
                Balance -= amount;

                message = AddLowBalanceFee();

                Transaction debitTrans = new Transaction(Name, DateTime.Today, amount, "Debit-Transfer", Balance);

                Transactions.Add(debitTrans);

                destinationAccount.balance += amount;

                Transaction creditTrans = new Transaction(destinationAccount.Name, DateTime.Today, amount, "Credit-Transfer", destinationAccount.balance);

                destinationAccount.Transactions.Add(creditTrans);

                message += "Amount of " + amount + " dollars was transferred from the " + Name + " account to the " + destinationAccount.name + " account.";

            }
            else
            {
                message = "Insufficient Funds! Nice try!";
            }

            return message;
        }

        public string SignCheck(decimal amount, string recipient)
        {
            if (amount <= Balance)
            {
                Balance -= amount;

                Transaction newTrans = new Transaction(Name, DateTime.Today, amount, "Debit-Check", Balance);

                Transactions.Add(newTrans);

                return "A check of " + amount + " dollars was issued to " + recipient + " from the " + Name + " account.";
            }
            else
            {
                return "Insufficient Funds! Try to save some money and come back later!";
            }
        }

        public void DisplayTransactions(ref ListBox lstDisplay, Account account)
        {
            lstDisplay.Items.Clear();
            lstDisplay.Items.AddRange(account.transactions.ToArray());
        }

        public string AddInterest()
        {
            decimal interest;
            string message = string.Empty;

            if (Name == "PremierSavings")
            {
                interest = Balance * PREMIER_SAVINGS_INTEREST_RATE;
                
                Deposit(interest);

                message = "The amount of " + interest.ToString("c2") + " which is an interest of " + PREMIER_SAVINGS_INTEREST_RATE.ToString("p") + " was applied to your Premier Savings account.";

            } 
            else
            {
               message = "Account doesn't qualify for any interest";
            }

            return message;
        }

        public string AddLowBalanceFee()
        {
            string message = string.Empty;

            if (Name == "PremierSavings")
            {
                if (Balance < PREMIER_SAVINGS_LOW_BALANCE_LIMIT && !LowBalanceApplied) {

                    Balance -= PREMIER_SAVINGS_LOW_BALANCE_FEE;

                    LowBalanceApplied = true;

                    message = "A low balance fee of " + PREMIER_SAVINGS_LOW_BALANCE_FEE + " dollars was applied to the Premier Savings account. ";
                } 
            }
            return message;
        }
    }
}
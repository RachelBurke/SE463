using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//This tutorial can be found at https://msdn.microsoft.com/en-us/library/ms182532.aspx
//
namespace BankUnitTestTutorial
{
        /// <summary>   
        /// Bank Account demo class.   
        /// </summary>   
        public class BankAccount
        {

            // class under test  
            public const string DebitAmountExceedsBalanceMessage = "Debit amount exceeds balance";
            public const string DebitAmountLessThanZeroMessage = "Debit amount less than zero";
            public const string BalanceAmountLessThan1000Message = "$10 low balance fee applied";
            public const string BalanceAmountLessThan0Message = "Balance Below Zero";


            private string m_customerName;

            private double m_balance;

            private bool m_frozen = false;

            //constructors
            private BankAccount()
            {
            }

            public BankAccount(string customerName, double balance)
            {
                m_customerName = customerName;
                m_balance = balance;
            }

            public string CustomerName
            {
                get { return m_customerName; }
            }

            public double Balance
            {
                get { return m_balance; }
            }

            public void Debit(double amount)
            {
                if (m_frozen)
                {
                    throw new Exception("Account frozen");
                }

                if (amount > m_balance)
                {
                    throw new ArgumentOutOfRangeException("amount", amount, DebitAmountExceedsBalanceMessage);
                }

                if (amount < 0)
                {
                    throw new ArgumentOutOfRangeException("amount", amount, DebitAmountLessThanZeroMessage);
                }

                //m_balance += amount; // intentionally incorrect code initially

                m_balance -= amount; // corrected code
                
                if (m_balance < 1000)
                {
                    LowBalanceFee(m_balance);
                    throw new ArgumentOutOfRangeException("balance", m_balance, BalanceAmountLessThan1000Message);
                }

        }

            public void Credit(double amount)
            {
                if (m_frozen)
                {
                    throw new Exception("Account frozen");
                }

                if (amount < 0)
                {
                    throw new ArgumentOutOfRangeException("amount");
                }

                m_balance += amount; // correct code
                //m_balance -= amount;     //injected fault - not caught by test
            }

            private void FreezeAccount()
            {
                m_frozen = true;
            }

            private void UnfreezeAccount()
            {
                m_frozen = false;
            }

            public void LowBalanceFee(double m_balance)
            {   
                if (m_balance >= 10)
                {
                    m_balance -= 10;
                }

                if(m_balance > 0 && m_balance < 10)
                {
                    m_balance = 0;
                }
            }

            public static void Main()
            {
                BankAccount ba = new BankAccount("Mr. Bryan Walton", 11.99);

                ba.Credit(5.77);
                ba.Debit(11.22);
                Console.WriteLine("Current balance is ${0}", ba.Balance);
            }

        }
    }


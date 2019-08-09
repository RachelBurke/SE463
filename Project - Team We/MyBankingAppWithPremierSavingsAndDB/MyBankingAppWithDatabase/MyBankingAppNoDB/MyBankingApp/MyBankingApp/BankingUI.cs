using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//AUTHOR: Panos Linos
//Date: November 2017
//DESCRIPTION: A windows app that simulates a typical banking system that allows the user to complete various transactions 
//including deposit, withdrawl, transfer and issue a check.

namespace MyBankingApp
{
    public partial class BankingUI : Form
    {
        private Account objCheckingAccount;
        private Account objSavingsAccount;
        private Account objPremierSavingsAccount;

        private DatabaseManager objDatabaseManager;

        //const string connection = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 
        //                           C:\Users\97rac\Documents\Butler\School\Year 3 - Junior\Semester 6\SE463\Project - Team We\MyBankingAppWithPremierSavingsAndDB\MyBankingAppWithDatabase\MyBankingAppNoDB\MyBankingApp\MyBankingApp\BankingDatabase.mdf";
        public BankingUI()
        {
            InitializeComponent();
            
            objCheckingAccount = new Account(0,"Checking");
            objSavingsAccount = new Account(0, "Savings");
            objPremierSavingsAccount = new Account(0, "PremierSavings");

            objDatabaseManager = new DatabaseManager(getConnectionString());

        }

        private string getConnectionString()
        {
            string connection = string.Empty;

            MessageBox.Show("This application requires connection to a database back-end.\n Click the OK button and then select the .mdf database file you wish to connect with.",
                "Welcome to the Banking application! ",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                connection = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = ";

                string mdfDirectory = openFileDialog1.FileName;

                connection += mdfDirectory;

            }

            return connection;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstTransactions.Items.Clear();

            txtCheckOrder.Text = string.Empty;
            txtCheckPay.Text = string.Empty;
            txtDeposit.Text = string.Empty;
            txtTransfer.Text = string.Empty;
            txtWithdraw.Text = string.Empty;

            lblBalance.Text = string.Empty;
            lblToday.Text = DateTime.Today.ToShortDateString();
            lblStatusMessage.Text = string.Empty;

            cbxTransfer.SelectedIndex = -1;
            cbxAccount.SelectedIndex = -1;
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            decimal amount;

            if (cbxAccount.Text == "Checking")
            {
                if (Decimal.TryParse(txtDeposit.Text, out amount) && amount > 0)
                {

                    lblStatusMessage.Text = objCheckingAccount.Deposit(amount);

                    objCheckingAccount.DisplayTransactions(ref lstTransactions, objCheckingAccount);

                    lblBalance.Text = objCheckingAccount.balance.ToString("c2");
                }
                else
                {
                    lblStatusMessage.Text = "Invalid input for deposit amount to the Checking account. Please enter a numeric value greater than zero. ";
                }

            }
            else if (cbxAccount.Text == "Savings")
            {
                if (Decimal.TryParse(txtDeposit.Text, out amount) && amount > 0)
                {
                    lblStatusMessage.Text = objSavingsAccount.Deposit(amount);

                    objSavingsAccount.DisplayTransactions(ref lstTransactions, objSavingsAccount);

                    lblBalance.Text = objSavingsAccount.balance.ToString("c2");

                }
                else
                {
                    lblStatusMessage.Text = "Invalid input for deposit to Savings account. Please enter a numeric value greater than zero.";
                }

            }
            else if (cbxAccount.Text == "Premier Savings")
            {
                if (Decimal.TryParse(txtDeposit.Text, out amount) && amount > 0)
                {
                    lblStatusMessage.Text = objPremierSavingsAccount.Deposit(amount);

                    objPremierSavingsAccount.DisplayTransactions(ref lstTransactions, objPremierSavingsAccount);

                    lblBalance.Text = objPremierSavingsAccount.balance.ToString("c2");
                }
                else
                {
                    lblStatusMessage.Text = "Invalid input for deposit to Premier Savings account. Please enter a numeric value greater than zero.";
                }
            }

            else
            {
                lblStatusMessage.Text = "Please select an account!";
            }

            txtDeposit.Text = string.Empty;
        }

        private void BankingUI_Load(object sender, EventArgs e)
        {

            lblToday.Text = DateTime.Today.ToShortDateString();

            lblBalance.Text = string.Empty;
        }

        private void cbxAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstTransactions.Items.Clear();

            if (cbxAccount.Text == "Checking")
            {
                lblBalance.Text = objCheckingAccount.balance.ToString("c2");

                lstTransactions.Items.AddRange(objCheckingAccount.transactions.ToArray());
                
            }
            else if (cbxAccount.Text == "Savings")
            {
                lblBalance.Text = objSavingsAccount.balance.ToString("c2");

                lstTransactions.Items.AddRange(objSavingsAccount.transactions.ToArray());
            }
            else if (cbxAccount.Text == "Premier Savings")
            {
                lblBalance.Text = objPremierSavingsAccount.balance.ToString("c2");

                lstTransactions.Items.AddRange(objPremierSavingsAccount.transactions.ToArray());
            }

            lblStatusMessage.Text = string.Empty;
            
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            decimal amount;

            if (cbxAccount.Text == "Checking")
            {
                if (Decimal.TryParse(txtWithdraw.Text, out amount) && amount > 0)
                {
                    lblStatusMessage.Text = objCheckingAccount.Withdraw(amount);

                    objCheckingAccount.DisplayTransactions(ref lstTransactions, objCheckingAccount);

                    lblBalance.Text = objCheckingAccount.balance.ToString("c2");
                }
                else
                {
                    lblStatusMessage.Text = "Invalid input for withraw from Checking account. Please enter a numeric value greater than zero.";
                }

            } else if (cbxAccount.Text == "Savings")
            {
                if (Decimal.TryParse(txtWithdraw.Text, out amount) && amount > 0)
                {
                    lblStatusMessage.Text = objSavingsAccount.Withdraw(amount);

                    objSavingsAccount.DisplayTransactions(ref lstTransactions, objSavingsAccount);

                    lblBalance.Text = objSavingsAccount.balance.ToString("c2");
                }
                else
                {
                    lblStatusMessage.Text = "Invalid input for withdraw from Savings account. Please enter a numeric value greater than zero.";
                }

            }
            else if (cbxAccount.Text == "Premier Savings")
            {
                if (Decimal.TryParse(txtWithdraw.Text, out amount) && amount > 0)
                {
                    lblStatusMessage.Text = objPremierSavingsAccount.Withdraw(amount);

                    objPremierSavingsAccount.DisplayTransactions(ref lstTransactions, objPremierSavingsAccount);

                    lblBalance.Text = objPremierSavingsAccount.balance.ToString("c2");

                }
                else
                {
                    lblStatusMessage.Text = "Invalid input for withdraw from Premier Savings account. Please enter a numeric value greater than zero.";
                }
            }
            else
            {
                lblStatusMessage.Text = "Please select an account!";
            }

            txtWithdraw.Text = string.Empty;
        }

        private void cbxTransfer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTransfer.Text == "Checking")
            {
                lblAccount.Text = "to Savings";
                lblBalance.Text = objCheckingAccount.balance.ToString("c2");
                cbxAccount.Text = "Checking";
            }
            else if (cbxTransfer.Text == "Savings")
            {
                lblAccount.Text = "to Checking";
                lblBalance.Text = objSavingsAccount.balance.ToString("c2");
                cbxAccount.Text = "Savings";
            }
            else if (cbxTransfer.Text == "Premier Savings")
            {
                //NOTE: We can tranfer from Premier Savings to Checking only
                lblAccount.Text = "to Checking";
                lblBalance.Text = objPremierSavingsAccount.balance.ToString("c2");
                cbxAccount.Text = "Premier Savings";
            }
          
            lblStatusMessage.Text = string.Empty;
            txtTransfer.Focus();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            decimal amount;

            if (cbxTransfer.Text == "Checking")
            {
                if (Decimal.TryParse(txtTransfer.Text, out amount) && amount > 0)
                {
                    lblStatusMessage.Text = objCheckingAccount.Transfer(amount,  ref objSavingsAccount);

                    objCheckingAccount.DisplayTransactions(ref lstTransactions, objCheckingAccount);

                    lblBalance.Text = objCheckingAccount.balance.ToString("c2");
                }
                else
                {
                    lblStatusMessage.Text = "Invalid input for transer from Checking. Please enter a numeric value greater than zero.";
                }

            } else if (cbxTransfer.Text == "Savings")
            {
                if (Decimal.TryParse(txtTransfer.Text, out amount) && amount > 0)
                {
                    lblStatusMessage.Text = objSavingsAccount.Transfer(amount, ref objCheckingAccount);

                    objSavingsAccount.DisplayTransactions(ref lstTransactions, objSavingsAccount);

                    lblBalance.Text = objSavingsAccount.balance.ToString("c2");
                }
                else
                {
                    lblStatusMessage.Text = "Invalid input for transfer from Savings. Please enter a numeric value greater than zero.";
                }

            } else if (cbxTransfer.Text == "Premier Savings")
            {
                if (Decimal.TryParse(txtTransfer.Text, out amount) && amount > 0)
                {
                    lblStatusMessage.Text = objPremierSavingsAccount.Transfer(amount, ref objCheckingAccount);
                    
                    objPremierSavingsAccount.DisplayTransactions(ref lstTransactions, objPremierSavingsAccount);

                    lblBalance.Text = objPremierSavingsAccount.balance.ToString("c2");
                }
                else
                {
                    lblStatusMessage.Text = "Invalid input for transfer from Premier Savings. Please enter a numeric value greater than zero.";
                }
            }
            else
            {
                lblStatusMessage.Text = "Please select an account!";
            }

            txtTransfer.Text = string.Empty;
        }

        private void btnSignCheck_Click(object sender, EventArgs e)
        {
            decimal amount;

            if (decimal.TryParse(txtCheckPay.Text, out amount) && amount > 0)
            {
                lblStatusMessage.Text = objCheckingAccount.SignCheck(amount, txtCheckOrder.Text);

                objCheckingAccount.DisplayTransactions(ref lstTransactions, objCheckingAccount);

                lblBalance.Text = objCheckingAccount.balance.ToString("c2");
            }
            else
            {
                lblStatusMessage.Text = "Invalid input for sign check amount. Please enter a numeric value greater than zero.";
            }

            txtCheckPay.Text = string.Empty;
            cbxAccount.Text = "Checking";
            txtCheckOrder.Text = string.Empty;
        }

        private void mnuDatabaseLoad_Click(object sender, EventArgs e)
        {

            objCheckingAccount.transactions = objDatabaseManager.LoadTransactions(objCheckingAccount);

            objCheckingAccount.balance = updateAccountBalance(objCheckingAccount);
          
            objSavingsAccount.transactions = objDatabaseManager.LoadTransactions(objSavingsAccount);

            objSavingsAccount.balance = updateAccountBalance(objSavingsAccount);

            objPremierSavingsAccount.transactions = objDatabaseManager.LoadTransactions(objPremierSavingsAccount);

            objPremierSavingsAccount.balance = updateAccountBalance(objPremierSavingsAccount);

            lblStatusMessage.Text = "Database Load Operation Completed!";
        }

        private decimal updateAccountBalance(Account account)
        {
            decimal balance=0m;

            foreach (Transaction tran in account.transactions)
            {
                balance = tran.currentBalance;
            }

           return balance;
        }
        
        private void mnuDatabaseSave_Click(object sender, EventArgs e)
        {
            objDatabaseManager.SaveTransactions(objCheckingAccount, objCheckingAccount.transactions);

            objDatabaseManager.SaveTransactions(objSavingsAccount, objSavingsAccount.transactions);

            objDatabaseManager.SaveTransactions(objPremierSavingsAccount, objPremierSavingsAccount.transactions);

            lblStatusMessage.Text = "Database Save Operation Completed!";
        }


        private void txtCheckPay_MouseClick(object sender, MouseEventArgs e)
        {
          cbxAccount.Text = "Checking";
          lblBalance.Text = objCheckingAccount.balance.ToString("c2");
        }

        private void btnAddInterest_Click(object sender, EventArgs e)
        {
            lblStatusMessage.Text = objPremierSavingsAccount.AddInterest();

            objPremierSavingsAccount.DisplayTransactions(ref lstTransactions, objPremierSavingsAccount);

            lblBalance.Text = objPremierSavingsAccount.balance.ToString("c2");
        }

        private void mnuDatabaseLoad_MouseDown(object sender, MouseEventArgs e)
        {
            lblStatusMessage.Text = "Database loading...";
        }

        private void mnuDatabaseSave_MouseDown(object sender, MouseEventArgs e)
        {
            lblStatusMessage.Text = "Database saving...";
        }
    }
}

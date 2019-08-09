using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Data.SqlClient;    // add this directive for Sql Server database connectivity

namespace MyBankingApp
{
    public class DatabaseManager
    {
        private SqlConnection ConnectionString;

        public DatabaseManager(string connection)
        {
            try
            {

                sqlConnection = new SqlConnection(); //create an instance of a new SqlConnection

                if (connection != string.Empty)
                {
                    sqlConnection.ConnectionString = connection; //set the connection string of the SqlConnection
                }
                else
                {
                    MessageBox.Show("You won't be able to connect to the database!", "The Database connection string is empty!:");
                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Something went wrong with the Database connection");
            }
        }

        public SqlConnection sqlConnection
        {
            get
            {
                return ConnectionString;
            }

            set
            {
                ConnectionString = value;
            }
        }


        public void SaveTransactions(Account account, List<Transaction> transactions)
        {
            string cmdStr;

            try
            {
                sqlConnection.Open();

                if (account.name == "Checking")
                {
                    //cmdStr = "INSERT INTO CheckingTransactions (accountname, date, amount, type, balance) " +
                    //" VALUES (@transname, @transdate, @transamount, @transtype, @transbalance)";

                    //insert a transaction in the TransactionChecking table that doesn't already exist
                    cmdStr = "INSERT INTO TransactionChecking (accountname, date, amount, type, balance) " +
                       "SELECT @transname, @transdate, @transamount, @transtype, @transbalance " +
                       "WHERE NOT EXISTS (SELECT accountname, date, amount, type, balance FROM TransactionChecking " +
                       "WHERE accountname = @transname AND date = @transdate AND amount = @transamount AND type = @transtype AND balance = @transbalance)";


                }
                else if (account.name == "Savings")
                {
                    //cmdStr = "INSERT INTO SavingsTransactions (accountname, date, amount, type, balance) " +
                    //    " VALUES (@transname, @transdate, @transamount, @transtype, @transbalance)";

                    //insert a transaction in the TransactionSavings table that doesn't already exist
                    cmdStr = "INSERT INTO TransactionSavings (accountname, date, amount, type, balance) " +
                        "SELECT @transname, @transdate, @transamount, @transtype, @transbalance " +
                        "WHERE NOT EXISTS (SELECT accountname, date, amount, type, balance FROM TransactionSavings " +
                        "WHERE accountname=@transname AND date=@transdate AND amount=@transamount AND type=@transtype AND balance=@transbalance)";
                }
                else if (account.name == "PremierSavings")
                {
                    //cmdStr = "INSERT INTO SavingsTransactions (accountname, date, amount, type, balance) " +
                    //    " VALUES (@transname, @transdate, @transamount, @transtype, @transbalance)";

                    //insert a transaction in the TransactionSavings table that doesn't already exist
                    cmdStr = "INSERT INTO TransactionPremierSavings (accountname, date, amount, type, balance) " +
                        "SELECT @transname, @transdate, @transamount, @transtype, @transbalance " +
                        "WHERE NOT EXISTS (SELECT accountname, date, amount, type, balance FROM TransactionPremierSavings " +
                        "WHERE accountname=@transname AND date=@transdate AND amount=@transamount AND type=@transtype AND balance=@transbalance)";
                }
                else
                {
                   cmdStr = null;
                }

                 if (cmdStr != null)
                 {
                    SqlCommand cmd = new SqlCommand(cmdStr);

                    cmd.Connection = sqlConnection;
    
                    foreach (var transaction in transactions)
                    {
                       cmd.Parameters.Clear();

                       cmd.Parameters.AddWithValue("@transname", transaction.accountname);
                       cmd.Parameters.AddWithValue("@transdate", transaction.date);
                       cmd.Parameters.AddWithValue("@transamount", transaction.amount);
                       cmd.Parameters.AddWithValue("@transtype", transaction.type);
                       cmd.Parameters.AddWithValue("@transbalance", transaction.currentBalance);

                        cmd.ExecuteNonQuery();

                  }
                }
                else
                {
                    MessageBox.Show("Database connection string is empty!", "Warning");
                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Warning");

            }
            finally
            {
                sqlConnection.Close();
               
            }
        }

        public List<Transaction> LoadTransactions(Account account)
        {
            List<Transaction> transactions;

            transactions = new List<Transaction>();

            string sqlStr;

            try
            {

                sqlConnection.Open();

                if (account.name == "Checking")
                {
                    sqlStr = "SELECT * FROM TransactionChecking";
                }
                else if (account.name == "Savings")
                {
                    sqlStr = "SELECT * FROM TransactionSavings";
                }
                else if (account.name == "PremierSavings")
                {
                    sqlStr = "SELECT * FROM TransactionPremierSavings";
                }
                else
                {
                    sqlStr = null;
                }
                if (sqlStr != null)
                {
                    SqlCommand sqlCommand = new SqlCommand(sqlStr, sqlConnection);

                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    Transaction tempTransaction;

                    while (reader.Read())
                    {

                        string name = (string)reader["accountname"];
                        DateTime date = (DateTime)reader["date"];
                        decimal amount = (decimal)reader["amount"];
                        string type = (string)reader["type"];
                        decimal balance = (decimal)reader["balance"];

                        tempTransaction = new Transaction(name, date, amount, type, balance);

                        transactions.Add(tempTransaction);
                    }
                }
                else
                {
                    MessageBox.Show("Database connection string is empty!", "Warning");
                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Warning");

            }
            finally
            {
                sqlConnection.Close();

            }

            return transactions;
        }

    }
}
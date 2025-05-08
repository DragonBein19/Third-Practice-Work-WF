using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ThirdProgramingPractice.DB.Transaction
{
    internal class MySqlCommand_transaction
    {

        /// <summary>
        /// A method for creating a new row in the 'transaction' table.
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="TransactionName"></param>
        /// <param name="Amount"></param>
        public void CreateTransaction(MySqlConnection connection, string TransactionName, float Amount, string Description)
        {
            string Query = "INSERT INTO `transaction` (`Name`, `Amount`, `Description`, `Date`) VALUES (@Name, @Amount, @Description, @Date)";

            try
            {
                MySqlCommand createTransaction = new MySqlCommand(Query, connection);

                createTransaction.Parameters.Add("@Name", MySqlDbType.VarChar).Value = TransactionName;
                createTransaction.Parameters.Add("@Amount", MySqlDbType.Double).Value = Amount;
                createTransaction.Parameters.Add("@Description", MySqlDbType.VarChar).Value = Description;
                createTransaction.Parameters.Add("@Date", MySqlDbType.Date).Value = DateTime.Now.ToString("dd.MM.yy");

                createTransaction.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in MySqlCommand_transaction class. \nMethod CreateTransaction()\nError message: " + ex.Message);
            }
        }

        public int GetTransactionID(MySqlConnection connection, string TransactionName)
        {
            string Query = "SELECT `ID` FROM `transaction` WHERE `Name` = @Name";
            MySqlCommand getID = new MySqlCommand(Query, connection);
            int ID = 0;

            try
            {
                getID.Parameters.Add("@Name", MySqlDbType.VarChar).Value = TransactionName;
                using (MySqlDataReader reader = getID.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        ID = reader.GetInt16(0);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in MySqlCommand_transaction class. \nMethod GetTransactionID()\nError message: " + ex.Message);
            }

            return ID;
        }

        public float GetTransactionAmount(MySqlConnection connection, int TransactionID)
        {
            string Query = "SELECT `Amount` FROM `transaction` WHERE `ID` = @ID";
            float Amount = 0.0f;

            try
            {
                MySqlCommand GetAmount = new MySqlCommand(Query, connection);

                GetAmount.Parameters.Add("@ID", MySqlDbType.Int16).Value = TransactionID;

                using (MySqlDataReader reader = GetAmount.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Amount = reader.GetFloat(0);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in MySqlCommand_transaction class. \nMethod GetTransactionAmount()\nError message: " + ex.Message);
            }

            return Amount;
        }

        public string GetTransactionDescription(MySqlConnection connection, int TransactionID)
        {
            string Query = "SELECT `Description` FROM `transaction` WHERE `ID` = @ID";
            string Description = "";
            
            try
            {
                MySqlCommand GetAmount = new MySqlCommand(Query, connection);

                GetAmount.Parameters.Add("@ID", MySqlDbType.Int16).Value = TransactionID;

                using (MySqlDataReader reader = GetAmount.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Description = reader["Description"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in MySqlCommand_transaction class. \nMethod GetTransactionDescription()\nError message: " + ex.Message);
            }

            return Description;
        }

        public DateTime GetTransactionDate(MySqlConnection connection, int TransactionID)
        {
            string Query = "SELECT `Date` FROM `transaction` WHERE `ID` = @ID";
            DateTime Date = new DateTime();

            try
            {
                MySqlCommand GetAmount = new MySqlCommand(Query, connection);

                GetAmount.Parameters.Add("@ID", MySqlDbType.Int16).Value = TransactionID;

                using (MySqlDataReader reader = GetAmount.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Date = Convert.ToDateTime(reader["Date"]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in MySqlCommand_transaction class. \nMethod GetTransactionDate()\nError message: " + ex.Message);
            }

            return Date;
        }

        public string GetTransactionName(MySqlConnection connection, int TransactionID)
        {
            string Query = "SELECT `Name` FROM `transaction` WHERE `ID` = @ID";
            string name = "";

            try
            {
                MySqlCommand GetName = new MySqlCommand(Query, connection);

                GetName.Parameters.Add("@ID", MySqlDbType.Int16).Value = TransactionID;

                using (MySqlDataReader reader = GetName.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        name = reader["Name"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in MySqlCommand_transaction class. \nMethod GetTransactionName()\nError message: " + ex.Message);
            }

            return name;
        }

        public void UpdateTransaction(MySqlConnection connection, string Name, float Amount, string Description, int transactionID)
        {
            string Query = "UPDATE `transaction` SET `Name` = @Name, `Amount` = @Amount, `Description` = @Description WHERE `ID` = @ID";

            try
            {
                MySqlCommand Update = new MySqlCommand(Query, connection);
                Update.Parameters.Add("@Name", MySqlDbType.VarChar).Value = Name;
                Update.Parameters.Add("@Amount", MySqlDbType.Float).Value = Amount;
                Update.Parameters.Add("@Description", MySqlDbType.VarChar).Value = Description;
                Update.Parameters.Add("ID", MySqlDbType.Int16).Value = transactionID;
                
                Update.ExecuteNonQuery();

                MessageBox.Show("Transaction " + Name + " was updated.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in MySqlCommand_transaction class. \nMethod UpdateTransaction()\nError message: " + ex.Message);
            }
        }
    }
}

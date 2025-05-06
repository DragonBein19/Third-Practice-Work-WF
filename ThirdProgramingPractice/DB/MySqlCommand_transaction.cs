using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdProgramingPractice.DB
{
    internal class MySqlCommand_transaction
    {

        /// <summary>
        /// A method for creating a new row in the 'transaction' table.
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="TransactionName"></param>
        /// <param name="Amount"></param>
        public void CreateTransaction(MySqlConnection connection, string TransactionName, float Amount)
        {
            string Query = "INSERT INTO `transaction` (`Name`, `Amount`, `Description`, `Date`) VALUES (@Name, @Amount, @Description, @Date)";
           
            try
            {
                MySqlCommand createTransaction = new MySqlCommand(Query, connection);

                createTransaction.Parameters.Add("@Name", MySqlDbType.VarChar).Value = TransactionName;
                createTransaction.Parameters.Add("@Amount", MySqlDbType.Double).Value = Amount;
                createTransaction.Parameters.Add("@Description", MySqlDbType.VarChar).Value = "";
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
                    if(reader.Read())
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


        public string GetTransactionName(MySqlConnection connection, int TransactionID)
        {
            string Query = "SELECT `Name` FROM `transaction` WHERE `ID` = @ID";
            string name = "";

            try
            {
                MySqlCommand GetName = new MySqlCommand(Query, connection);

                GetName.Parameters.Add("@ID", MySqlDbType.Int16).Value = TransactionID;

                using(MySqlDataReader reader = GetName.ExecuteReader()) 
                { 
                    if(reader.Read())
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
    }
}

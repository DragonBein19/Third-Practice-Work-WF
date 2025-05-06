using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdProgramingPractice.DB
{
    internal class MySqlCommands_incomeList
    {
        public void InsertNewTransactionInList(MySqlConnection connection, int IncomeID, int TransactionID)
        {
            string Query = "INSERT INTO `incomelist` (`IncomeID`, `TransactionID`) VALUES (@IncomeID, @TransactionID)";
            MySqlCommand InsertNewTransaction = new MySqlCommand(Query, connection);

            try
            {
                InsertNewTransaction.Parameters.Add("@IncomeID", MySqlDbType.Int16).Value = IncomeID;
                InsertNewTransaction.Parameters.Add("@TransactionID", MySqlDbType.Int16).Value = TransactionID;

                InsertNewTransaction.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in MySqlCommands_incomeList class. \nMethod InsertNewTransactionInList(). \nError message: " + ex.Message);
            }
        }

        public void
    }
}

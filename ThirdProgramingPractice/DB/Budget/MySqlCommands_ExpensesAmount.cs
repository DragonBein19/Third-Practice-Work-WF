using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdProgramingPractice.DB.Budget
{
    /// <summary>
    /// The class responsible for interacting with the "expensesa" table. This table is 
    /// responsible for the total amount of all payments and the list of transactions.
    /// </summary>
    internal class MySqlCommands_ExpensesAmount
    {
        /// <summary>
        /// The method responsible for creating a new row in the "expensesa" table.
        /// </summary>
        /// <param name="connection">Currency data base connection.</param>
        public void CreateExpensesATable(MySqlConnection connection)
        {
            try
            {
                string Query = "INSERT INTO `expensesa` (`Amount`) VALUES (@Amount)";
                MySqlCommand CreateExpensesA = new MySqlCommand(Query, connection);

                CreateExpensesA.Parameters.Add("@Amount", MySqlDbType.Float).Value = 0.0f;

                CreateExpensesA.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in MySqlCommands_ExpensesAmount class.\nMethod CreateExpensesATable().\nError message: " + ex.Message);
            }
        }

        /// <summary>
        /// The method for retrieving the "ID" from the "expensesa" table.
        /// </summary>
        /// <param name="connection">Currency data base connection.</param>
        /// <returns>return "ID" form table "expensesa"</returns>
        public int GetExpensesAID(MySqlConnection connection)
        {
            string Query = "SELECT Max(`ID`) FROM `expensesa`";
            MySqlCommand GetID = new MySqlCommand(Query, connection);
            int ID = 0;

            try
            {
                object result = GetID.ExecuteScalar();

                if (result != DBNull.Value)
                {
                    ID = Convert.ToInt16(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in MySqlCommands_ExpensesAmount class.\nMethod GetExpensesAID().\nError message: " + ex.Message);
            }
            return ID;
        }

        /// <summary>
        /// The method for retrieving the "Amount" from the "expensesa" table.
        /// </summary>
        /// <param name="connection">Corrently data base connection</param>
        /// <param name="ID">Row "ID"</param>
        /// <returns></returns>
        public int GetExpensesAmount(MySqlConnection connection, int ID)
        {
            string Query = "SELECT `Amount` FROM `expensesa` WHERE `ID` = @ID";
            MySqlCommand GetAmount = new MySqlCommand(Query, connection);
            int Amount = 0;

            try
            {
                GetAmount.Parameters.Add("@ID", MySqlDbType.Int16).Value = ID;

                using (MySqlDataReader reader = GetAmount.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Amount = Convert.ToInt16(reader["Amount"]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in MySqlCommands_ExpensesAmount class.\nMethod GetExpensesAmount().\nError message: " + ex.Message);
            }

            return Amount;
        }
    }
}

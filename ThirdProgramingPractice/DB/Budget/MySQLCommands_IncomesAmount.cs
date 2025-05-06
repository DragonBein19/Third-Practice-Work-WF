using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdProgramingPractice.DB.Budget
{
    /// <summary>
    /// The class is responsible for interacting with the "incomea" table.
    /// </summary>
    internal class MySQLCommands_IncomesAmount
    {
        /// <summary>
        /// The method for creating a new row in the "incomea" table.
        /// </summary>
        /// <param name="connection">Corrently data base connection</param>
        public void CreateIncomeATable(MySqlConnection connection)
        {
            string Query = "INSERT INTO `incomea` (`Amount`) VALUES (@Amount)";

            try
            {
                MySqlCommand CreateIncomeA = new MySqlCommand(Query, connection);

                CreateIncomeA.Parameters.Add("@Amount", MySqlDbType.Float).Value = 0.0f;

                CreateIncomeA.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in class MySQLCommands_IncomesAmount.\nMethod CreateIncomeATable().\nError messgae: " + ex.Message);
            }
        }

        /// <summary>
        /// The method that returns the "ID" from the "incomea" table.
        /// </summary>
        /// <param name="connection">Corrently data base connection</param>
        /// <returns></returns>
        public int GetIncomeAID(MySqlConnection connection)
        {
            string Query = "SELECT Max(`ID`) FROM `incomea`";
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
                MessageBox.Show("Error in class MySQLCommands_IncomesAmount.\nMethod GetIncomeAID().\nError messgae: " + ex.Message);
            }

            return ID;
        }

        /// <summary>
        /// The method that returns the "Amount" from the "incomea" table.
        /// </summary>
        /// <param name="connection"></param>
        /// <returns>returned "ID" from table "incomea"</returns>
        public float GetIncomeAmount(MySqlConnection connection, int ID)
        {
            string Query = "SELECT `Amount` FROM `incomea` WHERE `ID` = @ID";
            MySqlCommand GetAmount = new MySqlCommand(Query, connection);
            float Amount = 0;

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
                MessageBox.Show("Error in class MySQLCommands_IncomesAmount.\nMethod GetIncomeAmount().\nError messgae: " + ex.Message);
            }

            return Amount;
        }
    }
}

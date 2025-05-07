using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdProgramingPractice.DB
{
    internal class MySQLCommands_Goal
    {
        
        /// <summary>
        /// Method witch created new row in table "goal" with variables "Name" and "Amount".
        /// </summary>
        /// <param name="connection">Currently data base connection.</param>
        /// <param name="Name">Variable "Name".</param>
        /// <param name="Amount">Variable "Amount".</param>
        public void CreateGoal(MySqlConnection connection, string Name, float Amount)
        {
            string Query = "INSERT INTO `goal` (`Name`, `Amount`) VALUES (@Name, @Amount)";

            try
            {
                MySqlCommand CreateNewGoal = new MySqlCommand(Query, connection);

                CreateNewGoal.Parameters.Add("@Name", MySqlDbType.VarChar).Value = Name;
                CreateNewGoal.Parameters.Add("@Amount", MySqlDbType.Float).Value = Amount;

                CreateNewGoal.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in MySQLCommands_Goal class.\nMethod CreateGoal.\nError message: " + ex.Message);
            }
        }

        public int GetCreatedID (MySqlConnection connection)
        {
            int CreatedGoalID = 0;
            string Query = "SELECT max(ID) FROM goal";

            try
            {
                MySqlCommand GetID = new MySqlCommand(Query, connection);
                object result = GetID.ExecuteScalar();

                if (result != DBNull.Value)
                {
                    CreatedGoalID = Convert.ToInt16(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in class MySQLCommands_Goal.\nMethod GetCreatedID(). Error message: " + ex.Message);
            }

            return CreatedGoalID;
        }

        public void SetInGoalList(MySqlConnection connection, int accountID, int goalID)
        {
            string Query = "INSERT INTO `goals_list` (`accountID`, `goalID`) VALUES (@accountID, @goalID)";

            try
            {
                MySqlCommand SetInList = new MySqlCommand(Query, connection);
                SetInList.Parameters.Add("@accountID", MySqlDbType.Int16).Value = accountID;
                SetInList.Parameters.Add("@goalID", MySqlDbType.Int16).Value = goalID;

                SetInList.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in class MySQLCommands_Goal.\nMethod SetInGoalList(). Error message: " + ex.Message);
            }
        }
    }
}

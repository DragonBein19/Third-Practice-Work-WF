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
            string Query = "INSERT INTO `goal` (`Name`, `Amount`, `Currently`) VALUES (@Name, @Amount, @Currently)";

            try
            {
                MySqlCommand CreateNewGoal = new MySqlCommand(Query, connection);

                CreateNewGoal.Parameters.Add("@Name", MySqlDbType.VarChar).Value = Name;
                CreateNewGoal.Parameters.Add("@Amount", MySqlDbType.Float).Value = Amount;
                CreateNewGoal.Parameters.Add("@Currently", MySqlDbType.Float).Value = "0";

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

        public string GetGoalName(MySqlConnection connection, int goalID)
        {
            string Query = "SELECT `Name` FROM `goal` WHERE `ID` = @ID;";
            string name = "";

            try
            {
                MySqlCommand GetName = new MySqlCommand (Query, connection);
                GetName.Parameters.Add("@ID", MySqlDbType.Int16).Value = goalID;

                using(MySqlDataReader reader = GetName.ExecuteReader())
                {
                    if(reader.Read())
                    {
                        name = reader.GetString(0);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in class MySQLCommands_Goal.\nMethod GetGoalName(). Error message: " + ex.Message);
            }

            return name;
        }

        public string GetGoalTask(MySqlConnection connection, int goalID)
        {
            string Query = "SELECT `Amount` FROM `goal` WHERE `ID` = @ID;";
            string Amount = "";

            try
            {
                MySqlCommand GetName = new MySqlCommand(Query, connection);
                GetName.Parameters.Add("@ID", MySqlDbType.Int16).Value = goalID;

                using (MySqlDataReader reader = GetName.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int task = reader.GetInt16(0);
                        Amount = task.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in class MySQLCommands_Goal.\nMethod GetGoalTask(). Error message: " + ex.Message);
            }

            return Amount;
        }

        public string GetGoalCurrency(MySqlConnection connection, int goalID)
        {
            string Query = "SELECT `Currently` FROM `goal` WHERE `ID` = @ID;";
            string Currency = "0";

            try
            {
                MySqlCommand GetCurrency = new MySqlCommand(Query, connection);
                GetCurrency.Parameters.Add("@ID", MySqlDbType.Int16).Value = goalID;

                using (MySqlDataReader reader = GetCurrency.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int task = reader.GetInt16(0);
                        Currency = task.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in class MySQLCommands_Goal.\nMethod GetGoalCurrency(). Error message: " + ex.Message);
            }

            return Currency;
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

        public void UpdateGoal(MySqlConnection connection, string Name, double Amount, double Currently, int GoalID)
        {
            string Query = "UPDATE `goal` SET `Name` = @Name, `Amount` = @Amount, `Currently` = @Currently WHERE `ID` = @ID";

            try
            {
                MySqlCommand Update = new MySqlCommand(Query, connection);
                Update.Parameters.Add("@Name", MySqlDbType.VarChar).Value = Name;
                Update.Parameters.Add("@Amount", MySqlDbType.Float).Value = Amount;
                Update.Parameters.Add("@Currently", MySqlDbType.Float).Value = Currently;
                Update.Parameters.Add("@ID", MySqlDbType.Int16).Value = GoalID;

                Update.ExecuteNonQuery();

                MessageBox.Show("Goal was updated!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in class MySQLCommands_Goal.\nMethod UpdateGoal(). Error message: " + ex.Message);
            }
        }
    }
}

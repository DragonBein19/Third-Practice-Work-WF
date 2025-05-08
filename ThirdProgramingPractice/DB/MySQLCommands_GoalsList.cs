using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdProgramingPractice.DB
{
    internal class MySQLCommands_GoalsList
    {

        public List<string> GetGoalsList(MySqlConnection connection, int accountID)
        {
            string QueryGetID = "SELECT `goalID` FROM `goals_list` WHERE `accountID` = @accountID";
            List<int> GoalsID = new List<int>();
            List<string> GoalsName = new List<string>();

            try
            {
                MySqlCommand GetGoalID = new MySqlCommand(QueryGetID, connection);
                GetGoalID.Parameters.Add("@accountID", MySqlDbType.Int16).Value = accountID;

                using (MySqlDataReader reader = GetGoalID.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        GoalsID.Add(reader.GetInt16(0));
                    }
                }

                for(int i = 0; i < GoalsID.Count; i++)
                {
                    GoalsName.Add(GetGoalName(connection, GoalsID[i]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in MySQLCommands_GoalsList class.\nMethod GetGoalsList().\nError message: " + ex.Message);
            }
            return GoalsName;
        }

        private string GetGoalName(MySqlConnection connection, int GoalsID)
        {
            string QueryGetList = "SELECT `Name` FROM `goal` WHERE `ID` = @ID";
            string GoalName = "";

            MySqlCommand GetGoalName = new MySqlCommand(QueryGetList, connection);
            GetGoalName.Parameters.Add("@ID", MySqlDbType.Int16).Value = GoalsID;

            using (MySqlDataReader reader = GetGoalName.ExecuteReader())
            {
                while (reader.Read())
                {
                    GoalName = reader.GetString(0);
                }
            }

            return GoalName;
        }

        public List<int> GiveGoalsIdList(MySqlConnection connection, int accountID)
        {
            string Query = "SELECT `goalID` FROM `goals_list` WHERER `accountID` = @accountID";
            List<int> GoalID = new List<int>();

            try
            {
                MySqlCommand GiveGoalsList = new MySqlCommand(Query, connection);
                GiveGoalsList.Parameters.Add("@accountID", MySqlDbType.Int16).Value = accountID;

                using (MySqlDataReader reader = GiveGoalsList.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        GoalID.Add(Convert.ToInt16(reader[0]));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in MySQLCommands_GoalsList class.\nMethod GiveGoalsIdList().\nError message: " + ex.Message);
            }

            return GoalID;
        }
    }
}

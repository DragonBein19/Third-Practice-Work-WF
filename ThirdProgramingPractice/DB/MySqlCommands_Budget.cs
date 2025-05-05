using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdProgramingPractice.DB
{
    internal class MySqlCommands_Budget
    {
        public void CreateBudget(MySqlConnection connection, string BudgetName)
        {
            string QueryCreateBudget = "INSERT INTO `budget` (`Name`) VALUES (@Name)";

            try
            {
                MySqlCommand CreateNewBudget = new MySqlCommand(QueryCreateBudget, connection);
                CreateNewBudget.Parameters.Add("@Name", MySqlDbType.VarChar).Value = BudgetName;

                CreateNewBudget.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public int GetBudgetID(MySqlConnection connection, string BudgetName)
        {
            string QuerySelectBudgetID = "SELECT `ID` FROM `budget` WHERE `Name` = @Name";
            int BudgetID = 0;

            try
            {
                MySqlCommand SelectBudgetID = new MySqlCommand(QuerySelectBudgetID, connection);
                SelectBudgetID.Parameters.Add("@Name", MySqlDbType.VarChar).Value = BudgetName;

                using (MySqlDataReader reader = SelectBudgetID.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        BudgetID = Convert.ToInt16(reader["ID"]);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return BudgetID;
        }

        private string GetBudgetName(MySqlConnection connection, int budgetID)
        {
            string queryGetName = "SELECT `Name` FROM `budget` WHERE `ID` = @ID";
            string name = "";

            try
            {
                MySqlCommand SelecetName = new MySqlCommand(queryGetName, connection);

                SelecetName.Parameters.Add("@ID", MySqlDbType.Int16).Value = budgetID;

                using (MySqlDataReader reader2 = SelecetName.ExecuteReader())
                {
                    if (reader2.Read())
                    {
                        name = reader2["Name"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return name;
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public void AddBudgetsList(MySqlConnection connection, string BudgetName, int accountID)
        {
            string QuerryAddToList = "INSERT INTO `budgets` (`account_ID`,`budget_ID`) VALUES (@account_ID, @Budget_ID)";

            try
            {
                MySqlCommand AddToListBudgets = new MySqlCommand(QuerryAddToList, connection);

                AddToListBudgets.Parameters.Add("@account_ID", MySqlDbType.Int16).Value = accountID;
                AddToListBudgets.Parameters.Add("@Budget_ID", MySqlDbType.Int16).Value = GetBudgetID(connection, BudgetName);

                AddToListBudgets.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public string[] GetBudgetsList(MySqlConnection connection, int accountID)
        {
            string query = "SELECT `budget_ID` FROM `budgets` WHERE `account_ID` = @accountID";
            string[] SendingArray = new string[100];
            int i = 0;

            try
            {
                MySqlCommand SelectAllBudgetID = new MySqlCommand(query, connection);

                SelectAllBudgetID.Parameters.Add("@accountID", MySqlDbType.Int16).Value = accountID;

                using (MySqlDataReader reader1 = SelectAllBudgetID.ExecuteReader())
                {
                    while (reader1.Read())
                    {
                        SendingArray[i] = GetBudgetName(connection, Convert.ToInt16(reader1["budget_ID"]));
                        i++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return SendingArray;
        }
    }
}

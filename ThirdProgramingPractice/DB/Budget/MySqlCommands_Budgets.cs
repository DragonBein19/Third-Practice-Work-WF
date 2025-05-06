using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdProgramingPractice.DB.Budget
{
    /// <summary>
    /// The class is responsible for creating the relationship between the account and budgets.
    /// </summary>
    internal class MySqlCommands_Budgets
    {
        /// <summary>
        /// In this list, we add the linkage of the created budget to the account.
        /// </summary>
        /// <param name="connection">Corrently data base connection.</param>
        /// <param name="budgetID">"variable "ID" from table "budget".</param>
        /// <param name="accountID">variable "ID" from table "account"</param>
        public void AddBudgetsList(MySqlConnection connection, int budgetID, int accountID)
        {
            string QuerryAddToList = "INSERT INTO `budgets` (`account_ID`,`budget_ID`) VALUES (@account_ID, @Budget_ID)";

            try
            {
                MySqlCommand AddToListBudgets = new MySqlCommand(QuerryAddToList, connection);

                AddToListBudgets.Parameters.Add("@account_ID", MySqlDbType.Int16).Value = accountID;
                AddToListBudgets.Parameters.Add("@Budget_ID", MySqlDbType.Int16).Value = budgetID;

                AddToListBudgets.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in class MySqlCommands_Budgets.\nMethod AddBudgetsList().\nError message: " + ex.Message);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="accountID"></param>
        /// <returns>Returns List<string> with "budget-ID from table "budgets"</returns>
        public List<string> GetBudgetsList(MySqlConnection connection, int accountID)
        {
            string query = "SELECT `budget_ID` FROM `budgets` WHERE `account_ID` = @accountID";
            List<string> SendingArray = new List<string>();

            MySqlCommands_BudgetTable budget = new MySqlCommands_BudgetTable();

            try
            {
                MySqlCommand SelectAllBudgetID = new MySqlCommand(query, connection);
                DataTable table = new DataTable();

                SelectAllBudgetID.Parameters.Add("@accountID", MySqlDbType.Int16).Value = accountID;

                MySqlDataAdapter adapter = new MySqlDataAdapter(SelectAllBudgetID);

                adapter.Fill(table);

                for (int i = 0; i < table.Rows.Count; i++)
                {
                    SendingArray.Add(budget.GetBudgetNames(connection, Convert.ToInt16(table.Rows[i]["budget_ID"])));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in class MySqlCommands_Budgets.\nMethod GetBudgetsList().\nError message: " + ex.Message);
            }

            return SendingArray;
        }
    }
}

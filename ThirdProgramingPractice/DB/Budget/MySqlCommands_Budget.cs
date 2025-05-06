using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdProgramingPractice.DB.Budget
{
    internal class MySqlCommands_BudgetTable
    {
        /// <summary>
        /// The method is responsible for creating a new budget. This method creates three tables: "expensesa", "incomea",
        /// and "budget". Afterward, it links them all in the "budget" table using the foreign keys "Expenses_ID" and 
        /// "Income_ID".
        /// </summary>
        /// <param name="connection">Currently data base connection</param>
        /// <param name="BudgetName">The saved budget name required for creating a new budget.</param>
        public void CreateBudget(MySqlConnection connection, string BudgetName)
        {
            string QueryCreateBudget = "INSERT INTO `budget` (`Name`,`Expenses_ID`,`Income_ID`, `Amount`) VALUES (@Name, @ExpensesID, @IncomeID, @Amount)";

            try
            {
                MySqlCommands_ExpensesAmount expensesaTable = new MySqlCommands_ExpensesAmount();
                MySQLCommands_IncomesAmount incomeaTable = new MySQLCommands_IncomesAmount();

                expensesaTable.CreateExpensesATable(connection);
                incomeaTable.CreateIncomeATable(connection);

                MySqlCommand CreateNewBudget = new MySqlCommand(QueryCreateBudget, connection);
                CreateNewBudget.Parameters.Add("@Name", MySqlDbType.VarChar).Value = BudgetName;
                CreateNewBudget.Parameters.Add("@ExpensesID", MySqlDbType.Int16).Value = expensesaTable.GetExpensesAID(connection);
                CreateNewBudget.Parameters.Add("@IncomeID", MySqlDbType.Int16).Value = incomeaTable.GetIncomeAID(connection);

                float IncomeAmount = incomeaTable.GetIncomeAmount(connection, incomeaTable.GetIncomeAID(connection));
                float ExpensesAmount = expensesaTable.GetExpensesAmount(connection, expensesaTable.GetExpensesAID(connection));

                CreateNewBudget.Parameters.Add("@Amount", MySqlDbType.Float).Value = IncomeAmount - ExpensesAmount;

                CreateNewBudget.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in class MySqlCommands_Budget.\nMethod CreateBudget().\nError message: " + ex.Message);
            }
        }

        /// <summary>
        /// "Method that returns ID"
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="BudgetName"></param>
        /// <returns>Returned "ID" from table "budget"</returns>
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
                MessageBox.Show("Error in class MySqlCommands_Budget.\nMethod GetBudgetID().\nError message: " + ex.Message);
            }

            return BudgetID;
        }

        /// <summary>
        /// A method that returns the budget name using the budget ID.
        /// </summary>
        /// <param name="connection">СCurrency to data base connection</param>
        /// <param name="BudgetID">Varible "ID" from table "budget"</param>
        /// <returns>return budget name</returns>
        public string GetBudgetNames(MySqlConnection connection, int BudgetID)
        {
            string queryGetName = "SELECT `Name` FROM `budget` WHERE `ID` = @ID";
            string name = "";

            try
            {
                MySqlCommand SelecetName = new MySqlCommand(queryGetName, connection);

                SelecetName.Parameters.Add("@ID", MySqlDbType.Int16).Value = BudgetID;

                using (MySqlDataReader reader = SelecetName.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        name = reader["Name"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in class MySqlCommands_Budget.\nMethod GetBudgetNames().\nError message: " + ex.Message);
            }

            return name;
        }


        /// <summary>
        /// A method to retrieve the amount name of the selected budget.
        /// </summary>
        /// <param name="connection">Currently data base conncetion</param>
        /// <param name="BudgetName">Chosen budget name</param>
        /// <returns></returns>
        public float GetBudgetAmount(MySqlConnection connection, string BudgetName)
        {
            string Query = "SELECT `Amount` FROM `budget` WHERE `Name` = @Name";
            MySqlCommand GetAmount = new MySqlCommand(Query, connection);
            float Amount = 0.0f;

            try
            {
                GetAmount.Parameters.Add("@Name", MySqlDbType.VarChar).Value = BudgetName;

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
                MessageBox.Show("Error in class MySqlCommands_Budget.\nMethod GetBudgetAmount().\nError message: " + ex.Message);
            }

            return Amount;
        }

        /// <summary>
        /// A method that returns the foreign key 'expenses_ID'.
        /// </summary>
        /// <param name="connection">Currently data base connection</param>
        public int GetBudgetExpenses(MySqlConnection connection, int ID)
        {
            string Query = "SELECT `Expenses_ID` FROM `budget` WHERE `ID` = @ID";
            MySqlCommand GetExpenses = new MySqlCommand(Query, connection);
            int ExpensesID = 0;

            try
            {
                GetExpenses.Parameters.Add("@ID", MySqlDbType.Int16).Value = ID;

                using (MySqlDataReader reader = GetExpenses.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        ExpensesID = Convert.ToInt16(reader["Expenses_ID"]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in class MySqlCommands_Budget.\nMethod GetBudgetExpenses().\nError message: " + ex.Message);
            }

            return ExpensesID;
        }

        /// <summary>
        /// A method that returns the foreign key 'Income_ID'.
        /// </summary>
        /// <param name="connection">Currently data base connection</param>
        public int GetBudgetIncome(MySqlConnection connection, int ID)
        {
            string Query = "SELECT `Income_ID` FROM `budget` WHERE `ID` = @ID";
            MySqlCommand GetExpenses = new MySqlCommand(Query, connection);
            int ExpensesID = 0;

            try
            {
                GetExpenses.Parameters.Add("@ID", MySqlDbType.Int16).Value = ID;

                using (MySqlDataReader reader = GetExpenses.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        ExpensesID = Convert.ToInt16(reader["Income_ID"]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in class MySqlCommands_Budget.\nMethod GetBudgetIncome().\nError message: " + ex.Message);
            }

            return ExpensesID;
        }
    }
}

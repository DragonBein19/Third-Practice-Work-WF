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
            string QueryCreateBudget = "INSERT INTO `budget` (`Name`,`Expenses_ID`,`Income_ID`, `Amount`) VALUES (@Name, @ExpensesID, @IncomeID, @Amount)";

            try
            {
                CreateIncomeATable(connection);
                CreateExpensesATable(connection);
                
                MySqlCommand CreateNewBudget = new MySqlCommand(QueryCreateBudget, connection);
                CreateNewBudget.Parameters.Add("@Name", MySqlDbType.VarChar).Value = BudgetName;
                CreateNewBudget.Parameters.Add("@ExpensesID", MySqlDbType.Int16).Value = GetExpensesAID(connection);
                CreateNewBudget.Parameters.Add("@IncomeID", MySqlDbType.Int16).Value = GetIncomeAID(connection);
                float IncomeAmount = GetIncomeAmount(connection, GetIncomeAID(connection));
                float ExpensesAmount = GetExpensesAmount(connection, GetExpensesAID(connection));
                CreateNewBudget.Parameters.Add("@Amount", MySqlDbType.Float).Value = IncomeAmount - ExpensesAmount;

                CreateNewBudget.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in CreateBudget method: " + ex.Message);
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

        private string GetBudgetNames(MySqlConnection connection, int BudgetID)
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
                MessageBox.Show("Error: " + ex.Message);
            }

            return name;
        }

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
                    if(reader.Read())
                    {
                        Amount = Convert.ToInt16(reader["Amount"]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in GetBudgetAmount method: " + ex.Message);
            }

            return Amount;
        }

        public int GetBudgetExpenses(MySqlConnection connection, string BudgetName)
        {
            string Query = "SELECT `Expenses_ID` FROM `budget` WHERE `Name` = @Name";
            MySqlCommand GetExpenses = new MySqlCommand(Query, connection);
            int ExpensesID = 0;

            try
            {
                GetExpenses.Parameters.Add("@Name", MySqlDbType.VarChar).Value = BudgetName;

                using (MySqlDataReader reader = GetExpenses.ExecuteReader())
                {
                    if(reader.Read())
                    {
                        ExpensesID = Convert.ToInt16(reader["Expenses_ID"]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in GetBudgetExpenses method: " + ex.Message);
            }

            return ExpensesID;
        }

        public int GetBudgetIncome(MySqlConnection connection, string BudgetName)
        {
            string Query = "SELECT `Income_ID` FROM `budget` WHERE `Name` = @Name";
            MySqlCommand GetExpenses = new MySqlCommand(Query, connection);
            int ExpensesID = 0;

            try
            {
                GetExpenses.Parameters.Add("@Name", MySqlDbType.VarChar).Value = BudgetName;

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
                MessageBox.Show("Error in GetBudgetIncome method: " + ex.Message);
            }

            return ExpensesID;
        }
        //---------------------------------------------------------------------------------Expenses Amount (ExpensesA)--------------------------------------------------------------------------------------------
        private void CreateExpensesATable(MySqlConnection connection)
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
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private int GetExpensesAID(MySqlConnection connection)
        {
            string Query = "SELECT Max(`ID`) FROM `expensesa`";
            MySqlCommand GetID = new MySqlCommand(Query, connection);
            int ID = 0;         
                       
            try
            {
                object result = GetID.ExecuteScalar();

                if(result != DBNull.Value)
                {
                    ID = Convert.ToInt16(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return ID;
        }

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
                MessageBox.Show("Error in GetExpensesAmount method: " + ex.Message);
            }
            
            return Amount;
        }

        //---------------------------------------------------------------------------------Income Amount(IncomeA)-------------------------------------------------------------------------------------------------
        private void CreateIncomeATable(MySqlConnection connection)
        {
            string Query = "INSERT INTO `incomea` (`Amount`) VALUES (@Amount)";
            MySqlCommand CreateIncomeA = new MySqlCommand(Query, connection);

            CreateIncomeA.Parameters.Add("@Amount", MySqlDbType.Float).Value = 0.0f;

            CreateIncomeA.ExecuteNonQuery();
        }

        private int GetIncomeAID(MySqlConnection connection)
        {
            string Query = "SELECT Max(`ID`) FROM `incomea`";
            MySqlCommand GetID = new MySqlCommand(Query, connection);
            int ID = 0;
            
            try
            {
                object result = GetID.ExecuteScalar();

                if(result != DBNull.Value)
                {
                    ID = Convert.ToInt16(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return ID;
        }

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
                MessageBox.Show("Error in GetIncomeAmount method: " + ex.Message);
            }
            
            return Amount;
        }
        //---------------------------------------------------------------------------------Budget List (Budgets)---------------------------------------------------------------------------------------------------
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

        public List<string> GetBudgetsList(MySqlConnection connection, int accountID)
        {
            string query = "SELECT `budget_ID` FROM `budgets` WHERE `account_ID` = @accountID";
            List<string> SendingArray = new List<string>();

            try
            {
                MySqlCommand SelectAllBudgetID = new MySqlCommand(query, connection);
                DataTable table = new DataTable();

                SelectAllBudgetID.Parameters.Add("@accountID", MySqlDbType.Int16).Value = accountID;

                MySqlDataAdapter adapter = new MySqlDataAdapter(SelectAllBudgetID);

                adapter.Fill(table);

                for(int i = 0; i < table.Rows.Count; i++)
                {
                    SendingArray.Add(GetBudgetNames(connection, Convert.ToInt16(table.Rows[i]["budget_ID"])));
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

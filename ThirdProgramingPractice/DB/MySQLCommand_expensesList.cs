using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdProgramingPractice.DB.Budget;

namespace ThirdProgramingPractice.DB
{
    internal class MySQLCommand_expensesList
    {
        public void InsertNewTransactionInList(MySqlConnection connection, int ExpenseseID, int TransactionID)
        {
            string Query = "INSERT INTO `expenseslist` (`ExpensesID`, `TransactionID`) VALUES (@ExpensesID, @TransactionID)";
            MySqlCommand InsertNewTransaction = new MySqlCommand(Query, connection);

            try
            {
                InsertNewTransaction.Parameters.Add("@ExpensesID", MySqlDbType.Int16).Value = ExpenseseID;
                InsertNewTransaction.Parameters.Add("@TransactionID", MySqlDbType.Int16).Value = TransactionID;

                InsertNewTransaction.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in MySQLCommand_expensesList class. \nMethod InsertNewTransactionInList(). \nError message: " + ex.Message);
            }
        }

        public List<string> GetTansactionList(MySqlConnection connection, int budgetID)
        {
            string Query = "SELECT `TransactionID` FROM `expenseslist` WHERE `ExpensesID` = @ExpensesID";
            List<string> SendingList = new List<string>();

            MySqlCommands_BudgetTable budget = new MySqlCommands_BudgetTable();
            MySqlCommand_transaction transaction = new MySqlCommand_transaction();
            int ExpensesID = budget.GetBudgetExpenses(connection, budgetID);
            
            try
            {
                MySqlCommand SelectAllTransactionID = new MySqlCommand(Query, connection);
                DataTable table = new DataTable();

                SelectAllTransactionID.Parameters.Add("@ExpensesID", MySqlDbType.Int16).Value = ExpensesID;

                MySqlDataAdapter adapter = new MySqlDataAdapter(SelectAllTransactionID);

                adapter.Fill(table);

                for(int i = 0; i < table.Rows.Count; i++)
                {
                    SendingList.Add(transaction.GetTransactionName(connection, Convert.ToInt16(table.Rows[i]["TransactionID"])));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in MySQLCommand_expensesList class. \nMethod GetTansactionList(). \nError message: " + ex.Message);
            }

            return SendingList;
        }
    }
}

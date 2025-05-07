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
    internal class MySqlCommands_incomeList
    {
        public void InsertNewTransactionInList(MySqlConnection connection, int IncomeID, int TransactionID)
        {
            string Query = "INSERT INTO `incomelist` (`IncomeID`, `TransactionID`) VALUES (@IncomeID, @TransactionID)";
            MySqlCommand InsertNewTransaction = new MySqlCommand(Query, connection);

            try
            {
                InsertNewTransaction.Parameters.Add("@IncomeID", MySqlDbType.Int16).Value = IncomeID;
                InsertNewTransaction.Parameters.Add("@TransactionID", MySqlDbType.Int16).Value = TransactionID;

                InsertNewTransaction.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in MySqlCommands_incomeList class. \nMethod InsertNewTransactionInList(). \nError message: " + ex.Message);
            }
        }

        public List<string> GetTransactionList(MySqlConnection connection, int budgetID)
        {
            string Query = "SELECT `TransactionID` FROM `incomelist` WHERE `IncomeID` = @IncomeID";
            List<string> SendingList = new List<string>();

            MySqlCommands_BudgetTable budget = new MySqlCommands_BudgetTable();
            MySqlCommand_transaction transaction = new MySqlCommand_transaction();
            int IncomesID = budget.GetBudgetExpenses(connection, budgetID);

            try
            {
                MySqlCommand SelectAllTransactionID = new MySqlCommand(Query, connection);
                DataTable table = new DataTable();

                SelectAllTransactionID.Parameters.Add("@IncomeID", MySqlDbType.Int16).Value = IncomesID;

                MySqlDataAdapter adapter = new MySqlDataAdapter(SelectAllTransactionID);

                if(table != null)
                {
                    adapter.Fill(table);
                }
                else
                {
                    SendingList.Add("No incomes");
                }

                for (int i = 0; i < table.Rows.Count; i++)
                {
                    SendingList.Add(transaction.GetTransactionName(connection, Convert.ToInt16(table.Rows[i]["TransactionID"])));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in MySqlCommands_incomeList class. \nMethod GetTransactionList(). \nError message: " + ex.Message);
            }

            return SendingList;
        }
    }
}
